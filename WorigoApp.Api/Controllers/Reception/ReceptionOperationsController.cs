using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Reception;

/// <summary>
/// ReceptionOperationsController sınıfını temsil eder.
/// </summary>
[ApiController]
[Authorize(Roles = "SystemAdmin,HotelAdmin,Management,DepartmentManager,Employee")]
[Route("api/reception/operations")]
public class ReceptionOperationsController : ControllerBase
{
    private readonly AppDbContext _db;
/// <summary>
/// ReceptionOperationsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public ReceptionOperationsController(AppDbContext db) => _db = db;

    /// <summary>
    /// GetContext işlemini gerçekleştirir.
    /// </summary>
[HttpGet("context")]
    public async Task<IActionResult> GetContext([FromQuery] int? hotelId, CancellationToken ct)
    {
        var context = await ResolveContextAsync(hotelId, ct);
        if (context is null) return Forbid();
        return Ok(new { isSuccess = true, data = context });
    }

    /// <summary>
    /// GetDayList işlemini gerçekleştirir.
    /// </summary>
[HttpGet("day-list")]
    public async Task<IActionResult> GetDayList([FromQuery] int? hotelId, [FromQuery] DateTime? date, CancellationToken ct)
    {
        var context = await ResolveContextAsync(hotelId, ct);
        if (context is null) return Forbid();
        var day = (date ?? DateTime.Today).Date;
        var nextDay = day.AddDays(1);

        var stays = await _db.GuestStays.AsNoTracking()
            .Include(x => x.Room).Include(x => x.Customers)
            .Where(x => x.HotelId == context.HotelId && !x.IsDeleted &&
                ((x.CheckInDate >= day && x.CheckInDate < nextDay) ||
                 (x.CheckOutDate >= day && x.CheckOutDate < nextDay)))
            .OrderBy(x => x.CheckInDate).ToListAsync(ct);

        var items = stays.Select(x => new
        {
            x.Id,
            roomId = x.RoomId,
            roomName = x.Room.RoomNumber ?? x.Room.Name,
            guestName = GuestName(x),
            x.ReservationNo,
            x.Channel,
            x.CheckInDate,
            x.CheckOutDate,
            x.ActualCheckInAt,
            x.ActualCheckOutAt,
            x.Status,
            x.IsVip,
            x.IsLateCheckOut,
            x.AdultCount,
            x.ChildCount,
            type = x.CheckInDate.Date == day ? "Arrival" : "Departure"
        });

        return Ok(new { isSuccess = true, data = items });
    }

    /// <summary>
    /// GetShiftNotes işlemini gerçekleştirir.
    /// </summary>
[HttpGet("shift-notes")]
    public async Task<IActionResult> GetShiftNotes([FromQuery] int? hotelId, [FromQuery] bool includeResolved = false, CancellationToken ct = default)
    {
        var context = await ResolveContextAsync(hotelId, ct);
        if (context is null) return Forbid();

        var query = _db.ReceptionShiftNotes.AsNoTracking()
            .Where(x => x.HotelId == context.HotelId && !x.IsDeleted);
        if (!includeResolved) query = query.Where(x => !x.IsResolved);

        var notes = await query.OrderByDescending(x => x.Priority == "Critical")
            .ThenByDescending(x => x.CreatedDate).Take(100)
            .Select(x => new { x.Id, x.Content, x.Priority, x.IsResolved, x.CreatedDate, x.ResolvedAt, x.CreatedByUserId })
            .ToListAsync(ct);
        return Ok(new { isSuccess = true, data = notes });
    }

    /// <summary>
    /// CreateShiftNote işlemini gerçekleştirir.
    /// </summary>
[HttpPost("shift-notes")]
    public async Task<IActionResult> CreateShiftNote([FromBody] CreateShiftNoteRequest request, CancellationToken ct)
    {
        var context = await ResolveContextAsync(request.HotelId, ct);
        if (context is null) return Forbid();
        var content = request.Content?.Trim();
        if (string.IsNullOrWhiteSpace(content)) return BadRequest(new { isSuccess = false, errors = new[] { "Not metni zorunludur." } });
        if (content.Length > 2000) return BadRequest(new { isSuccess = false, errors = new[] { "Not en fazla 2000 karakter olabilir." } });

        var priority = request.Priority is "Critical" or "High" or "Normal" ? request.Priority : "Normal";
        var note = new ReceptionShiftNote
        {
            HotelId = context.HotelId, CreatedByUserId = context.UserId,
            Content = content, Priority = priority
        };
        _db.ReceptionShiftNotes.Add(note);
        AddAudit(context, "ShiftNoteCreated", nameof(ReceptionShiftNote), null, priority);
        await _db.SaveChangesAsync(ct);
        return Ok(new { isSuccess = true, data = new { note.Id } });
    }

    /// <summary>
    /// ResolveShiftNote işlemini gerçekleştirir.
    /// </summary>
[HttpPatch("shift-notes/{id:int}/resolve")]
    public async Task<IActionResult> ResolveShiftNote(int id, [FromBody] ResolveShiftNoteRequest request, CancellationToken ct)
    {
        var context = await ResolveContextAsync(request.HotelId, ct);
        if (context is null) return Forbid();
        var note = await _db.ReceptionShiftNotes.FirstOrDefaultAsync(x => x.Id == id && x.HotelId == context.HotelId && !x.IsDeleted, ct);
        if (note is null) return NotFound(new { isSuccess = false, errors = new[] { "Vardiya notu bulunamadı." } });
        note.IsResolved = request.IsResolved;
        note.ResolvedAt = request.IsResolved ? DateTime.UtcNow : null;
        note.ResolvedByUserId = request.IsResolved ? context.UserId : null;
        note.ModifyDate = DateTime.Now;
        AddAudit(context, request.IsResolved ? "ShiftNoteResolved" : "ShiftNoteReopened", nameof(ReceptionShiftNote), note.Id, null);
        await _db.SaveChangesAsync(ct);
        return Ok(new { isSuccess = true });
    }

    /// <summary>
    /// ExtendStay işlemini gerçekleştirir.
    /// </summary>
[HttpPost("stays/{id:int}/extend")]
    public async Task<IActionResult> ExtendStay(int id, [FromBody] ExtendStayRequest request, CancellationToken ct)
    {
        var context = await ResolveContextAsync(request.HotelId, ct);
        if (context is null) return Forbid();
        var stay = await _db.GuestStays.Include(x => x.Room)
            .FirstOrDefaultAsync(x => x.Id == id && x.HotelId == context.HotelId && x.ActualCheckOutAt == null && !x.IsDeleted, ct);
        if (stay is null) return NotFound(new { isSuccess = false, errors = new[] { "Aktif konaklama bulunamadı." } });
        var newDate = request.NewCheckOutDate.Date;
        if (newDate <= stay.CheckOutDate.Date) return BadRequest(new { isSuccess = false, errors = new[] { "Yeni çıkış tarihi mevcut tarihten sonra olmalıdır." } });

        var conflict = await _db.GuestStays.AnyAsync(x => x.Id != stay.Id && x.RoomId == stay.RoomId && !x.IsDeleted &&
            x.ActualCheckOutAt == null && x.CheckInDate < newDate && x.CheckOutDate > stay.CheckOutDate, ct);
        if (conflict) return Conflict(new { isSuccess = false, errors = new[] { "Odanın yeni tarih aralığında başka rezervasyonu bulunuyor." } });

        var old = stay.CheckOutDate;
        var extraNights = (newDate - old.Date).Days;
        stay.CheckOutDate = newDate;
        if (request.AdditionalAmount > 0) stay.TotalPrice += request.AdditionalAmount;
        else stay.TotalPrice += stay.Room.Price * extraNights;
        stay.IsLateCheckOut = request.IsLateCheckOut;
        stay.ModifyDate = DateTime.Now;
        AddAudit(context, "StayExtended", nameof(GuestStay), stay.Id, $"{old:yyyy-MM-dd} -> {newDate:yyyy-MM-dd}");
        await _db.SaveChangesAsync(ct);
        return Ok(new { isSuccess = true, data = new { stay.CheckOutDate, stay.TotalPrice } });
    }

    /// <summary>
    /// MoveRoom işlemini gerçekleştirir.
    /// </summary>
[HttpPost("stays/{id:int}/move-room")]
    public async Task<IActionResult> MoveRoom(int id, [FromBody] MoveRoomRequest request, CancellationToken ct)
    {
        var context = await ResolveContextAsync(request.HotelId, ct);
        if (context is null) return Forbid();
        if (string.IsNullOrWhiteSpace(request.Reason)) return BadRequest(new { isSuccess = false, errors = new[] { "Oda değişikliği gerekçesi zorunludur." } });
        var stay = await _db.GuestStays.Include(x => x.Room)
            .FirstOrDefaultAsync(x => x.Id == id && x.HotelId == context.HotelId && x.ActualCheckOutAt == null && !x.IsDeleted, ct);
        var target = await _db.Room.FirstOrDefaultAsync(x => x.Id == request.TargetRoomId && x.HotelId == context.HotelId && !x.IsDeleted, ct);
        if (stay is null || target is null) return NotFound(new { isSuccess = false, errors = new[] { "Konaklama veya hedef oda bulunamadı." } });
        if (target.IsFull || !string.Equals(target.CurrentStatus, "Available", StringComparison.OrdinalIgnoreCase))
            return Conflict(new { isSuccess = false, errors = new[] { "Hedef oda girişe uygun değil." } });

        var oldRoom = stay.Room;
        oldRoom.IsFull = false; oldRoom.CurrentStatus = "Cleaning"; oldRoom.ModifyDate = DateTime.Now;
        target.IsFull = true; target.CurrentStatus = "Occupied"; target.ModifyDate = DateTime.Now;
        stay.RoomId = target.Id; stay.ModifyDate = DateTime.Now;
        AddAudit(context, "RoomMoved", nameof(GuestStay), stay.Id, $"{oldRoom.Id} -> {target.Id}; {request.Reason.Trim()}");
        await _db.SaveChangesAsync(ct);
        return Ok(new { isSuccess = true, data = new { roomId = target.Id, roomName = target.RoomNumber ?? target.Name } });
    }

    /// <summary>
    /// RotateMobileKey işlemini gerçekleştirir.
    /// </summary>
[HttpPost("stays/{id:int}/rotate-mobile-key")]
    public async Task<IActionResult> RotateMobileKey(int id, [FromBody] HotelScopedRequest request, CancellationToken ct)
    {
        var context = await ResolveContextAsync(request.HotelId, ct);
        if (context is null) return Forbid();
        var stay = await _db.GuestStays.FirstOrDefaultAsync(x => x.Id == id && x.HotelId == context.HotelId && x.ActualCheckOutAt == null && !x.IsDeleted, ct);
        if (stay is null) return NotFound(new { isSuccess = false, errors = new[] { "Aktif konaklama bulunamadı." } });
        var sessions = await _db.GuestSessions.Where(x => x.GuestStayId == id && x.IsActiveSession && !x.IsDeleted).ToListAsync(ct);
        foreach (var item in sessions) { item.IsActiveSession = false; item.ExpiresAt = DateTime.UtcNow; }
        var customerId = stay.PrimaryCustomerId ?? await _db.Customers.Where(x => x.GuestStayId == id && !x.IsDeleted).Select(x => x.Id).FirstOrDefaultAsync(ct);
        if (customerId <= 0) return BadRequest(new { isSuccess = false, errors = new[] { "Misafir kaydı bulunamadı." } });
        var token = CreateToken("qr");
        _db.GuestSessions.Add(new GuestSession { GuestStayId = id, CustomerId = customerId, SessionToken = CreateToken("session"), QrCodeToken = token, ExpiresAt = stay.CheckOutDate.ToUniversalTime().AddHours(6), LanguageCode = stay.GuestLanguageCode, IsActiveSession = true });
        AddAudit(context, "MobileKeyRotated", nameof(GuestStay), stay.Id, "Önceki aktif anahtarlar iptal edildi.");
        await _db.SaveChangesAsync(ct);
        return Ok(new { isSuccess = true, data = new { qrCodeToken = token } });
    }

    /// <summary>
    /// GetReservations işlemini gerçekleştirir.
    /// </summary>
[HttpGet("reservations")]
    public async Task<IActionResult> GetReservations([FromQuery] int? hotelId, [FromQuery] string? search, CancellationToken ct)
    {
        var context = await ResolveContextAsync(hotelId, ct); if (context is null) return Forbid();
        var query = _db.GuestStays.AsNoTracking().Include(x => x.Room).Include(x => x.Customers)
            .Where(x => x.HotelId == context.HotelId && !x.IsDeleted && x.ActualCheckInAt == null && x.ActualCheckOutAt == null && x.Status != "Cancelled");
        if (!string.IsNullOrWhiteSpace(search)) { var term = search.Trim(); query = query.Where(x => (x.ReservationNo ?? "").Contains(term) || x.Customers.Any(c => (c.Name + " " + c.SurName).Contains(term))); }
        var rows = await query.OrderBy(x => x.CheckInDate).Take(250).ToListAsync(ct);
        return Ok(new { isSuccess = true, data = rows.Select(x => new { x.Id, x.ReservationNo, x.Channel, x.CheckInDate, x.CheckOutDate, x.Status, x.AdultCount, x.ChildCount, x.TotalPrice, x.CurrencyCode, roomId=x.RoomId, roomName=x.Room.RoomNumber ?? x.Room.Name, guestName=GuestName(x), x.SpecialRequests }) });
    }

    /// <summary>
    /// CreateReservation işlemini gerçekleştirir.
    /// </summary>
[HttpPost("reservations")]
    public async Task<IActionResult> CreateReservation([FromBody] CreateReservationRequest request, CancellationToken ct)
    {
        var context = await ResolveContextAsync(request.HotelId, ct); if (context is null) return Forbid();
        if (request.CheckOutDate.Date <= request.CheckInDate.Date || string.IsNullOrWhiteSpace(request.GuestName) || string.IsNullOrWhiteSpace(request.GuestSurname)) return BadRequest(new { isSuccess=false, errors=new[]{"Misafir ve geçerli tarih aralığı zorunludur."} });
        var room = await _db.Room.FirstOrDefaultAsync(x => x.Id == request.RoomId && x.HotelId == context.HotelId && !x.IsDeleted, ct);
        if (room is null) return NotFound(new { isSuccess=false, errors=new[]{"Oda bulunamadı."} });
        var conflict = await _db.GuestStays.AnyAsync(x => x.RoomId == room.Id && !x.IsDeleted && x.Status != "Cancelled" && x.ActualCheckOutAt == null && x.CheckInDate < request.CheckOutDate.Date && x.CheckOutDate > request.CheckInDate.Date, ct);
        if (conflict) return Conflict(new { isSuccess=false, errors=new[]{"Oda seçilen tarihlerde müsait değil."} });
        var stay = new GuestStay { HotelId=context.HotelId, RoomId=room.Id, ReservationNo=string.IsNullOrWhiteSpace(request.ReservationNo)?$"RSV-{DateTime.UtcNow:yyyyMMddHHmmss}":request.ReservationNo.Trim(), Channel=request.Channel?.Trim()??"Direct", CheckInDate=request.CheckInDate.Date, CheckOutDate=request.CheckOutDate.Date, VerificationCode=RandomNumberGenerator.GetInt32(100000,999999).ToString(), Status="Reserved", AdultCount=Math.Max(1,request.AdultCount), ChildCount=Math.Max(0,request.ChildCount), TotalPrice=Math.Max(0,request.TotalPrice), CurrencyCode=request.CurrencyCode?.Trim().ToUpperInvariant()??"TRY", SpecialRequests=request.SpecialRequests?.Trim() };
        _db.GuestStays.Add(stay); await _db.SaveChangesAsync(ct);
        var customer = new Customer { GuestStayId=stay.Id, Name=request.GuestName.Trim(), SurName=request.GuestSurname.Trim(), PhoneNumber=request.Phone?.Trim(), Email=request.Email?.Trim(), IsPrimaryGuest=true };
        _db.Customers.Add(customer); await _db.SaveChangesAsync(ct); stay.PrimaryCustomerId=customer.Id;
        AddAudit(context,"ReservationCreated",nameof(GuestStay),stay.Id,stay.ReservationNo); await _db.SaveChangesAsync(ct);
        return Ok(new { isSuccess=true, data=new { stay.Id, stay.ReservationNo } });
    }

    /// <summary>
    /// UpdateReservationStatus işlemini gerçekleştirir.
    /// </summary>
[HttpPatch("reservations/{id:int}/status")]
    public async Task<IActionResult> UpdateReservationStatus(int id, [FromBody] ReservationStatusRequest request, CancellationToken ct)
    {
        var context=await ResolveContextAsync(request.HotelId,ct); if(context is null)return Forbid();
        var stay=await _db.GuestStays.FirstOrDefaultAsync(x=>x.Id==id&&x.HotelId==context.HotelId&&!x.IsDeleted,ct); if(stay is null)return NotFound();
        if(request.Status is not ("Cancelled" or "NoShow" or "Reserved"))return BadRequest(new {isSuccess=false,errors=new[]{"Geçersiz rezervasyon durumu."}});
        stay.Status=request.Status; stay.ModifyDate=DateTime.Now; AddAudit(context,"ReservationStatusChanged",nameof(GuestStay),id,request.Status); await _db.SaveChangesAsync(ct); return Ok(new{isSuccess=true});
    }

    /// <summary>
    /// GetHousekeeping işlemini gerçekleştirir.
    /// </summary>
[HttpGet("housekeeping")]
    public async Task<IActionResult> GetHousekeeping([FromQuery]int? hotelId,CancellationToken ct)
    {
        var context=await ResolveContextAsync(hotelId,ct); if(context is null)return Forbid();
        var rooms=await _db.Room.AsNoTracking().Include(x=>x.RoomType).Where(x=>x.HotelId==context.HotelId&&!x.IsDeleted).OrderBy(x=>x.FloorNo).ThenBy(x=>x.RoomNumber).Select(x=>new{x.Id,roomName=x.RoomNumber??x.Name,x.FloorNo,roomType=x.RoomType.Name,x.CurrentStatus,x.OperationalNote,x.StatusUpdatedAt,x.HousekeepingEmployeeId}).ToListAsync(ct);
        return Ok(new{isSuccess=true,data=rooms});
    }

    /// <summary>
    /// UpdateHousekeeping işlemini gerçekleştirir.
    /// </summary>
[HttpPost("housekeeping/{roomId:int}")]
    public async Task<IActionResult> UpdateHousekeeping(int roomId,[FromBody]HousekeepingUpdateRequest request,CancellationToken ct)
    {
        var context=await ResolveContextAsync(request.HotelId,ct); if(context is null)return Forbid();
        var allowed=new[]{"Cleaning","Inspection","Available","Maintenance","OutOfOrder","DndBlocked"}; if(!allowed.Contains(request.Status))return BadRequest(new{isSuccess=false,errors=new[]{"Geçersiz oda durumu."}});
        var room=await _db.Room.FirstOrDefaultAsync(x=>x.Id==roomId&&x.HotelId==context.HotelId&&!x.IsDeleted,ct); if(room is null)return NotFound();
        room.CurrentStatus=request.Status; room.IsFull=request.Status=="Occupied"; room.OperationalNote=request.Note?.Trim(); room.HousekeepingEmployeeId=request.EmployeeId; room.StatusUpdatedAt=DateTime.UtcNow; room.ModifyDate=DateTime.Now;
        AddAudit(context,"HousekeepingStatusChanged",nameof(Room),room.Id,$"{request.Status}: {request.Note}"); await _db.SaveChangesAsync(ct); return Ok(new{isSuccess=true});
    }

    /// <summary>
    /// GetCurrentCashShift işlemini gerçekleştirir.
    /// </summary>
[HttpGet("cash/current")]
    public async Task<IActionResult> GetCurrentCashShift([FromQuery]int? hotelId,CancellationToken ct)
    {
        var context=await ResolveContextAsync(hotelId,ct); if(context is null)return Forbid();
        var shift=await _db.ReceptionCashShifts.AsNoTracking().Include(x=>x.Transactions).Where(x=>x.HotelId==context.HotelId&&x.UserId==context.UserId&&x.Status=="Open"&&!x.IsDeleted).OrderByDescending(x=>x.Id).FirstOrDefaultAsync(ct);
        return Ok(new{isSuccess=true,data=shift is null?null:new{shift.Id,shift.OpenedAt,shift.OpeningBalance,shift.CashIncome,shift.CashExpense,expectedBalance=shift.OpeningBalance+shift.CashIncome-shift.CashExpense,transactions=shift.Transactions.OrderByDescending(x=>x.CreatedDate).Select(x=>new{x.Id,x.Type,x.Amount,x.Description,x.PaymentMethod,x.CreatedDate})}});
    }

    /// <summary>
    /// OpenCashShift işlemini gerçekleştirir.
    /// </summary>
[HttpPost("cash/open")]
    public async Task<IActionResult> OpenCashShift([FromBody]OpenCashShiftRequest request,CancellationToken ct)
    {
        var context=await ResolveContextAsync(request.HotelId,ct); if(context is null)return Forbid();
        if(await _db.ReceptionCashShifts.AnyAsync(x=>x.HotelId==context.HotelId&&x.UserId==context.UserId&&x.Status=="Open"&&!x.IsDeleted,ct))return Conflict(new{isSuccess=false,errors=new[]{"Açık kasa vardiyası zaten var."}});
        var shift=new ReceptionCashShift{HotelId=context.HotelId,UserId=context.UserId,OpeningBalance=Math.Max(0,request.OpeningBalance)}; _db.ReceptionCashShifts.Add(shift); AddAudit(context,"CashShiftOpened",nameof(ReceptionCashShift),null,$"{shift.OpeningBalance:N2}"); await _db.SaveChangesAsync(ct); return Ok(new{isSuccess=true,data=new{shift.Id}});
    }

    /// <summary>
    /// AddCashTransaction işlemini gerçekleştirir.
    /// </summary>
[HttpPost("cash/transaction")]
    public async Task<IActionResult> AddCashTransaction([FromBody]CashTransactionRequest request,CancellationToken ct)
    {
        var context=await ResolveContextAsync(request.HotelId,ct); if(context is null)return Forbid(); if(request.Amount<=0||string.IsNullOrWhiteSpace(request.Description))return BadRequest(new{isSuccess=false,errors=new[]{"Tutar ve açıklama zorunludur."}});
        var shift=await _db.ReceptionCashShifts.FirstOrDefaultAsync(x=>x.HotelId==context.HotelId&&x.UserId==context.UserId&&x.Status=="Open"&&!x.IsDeleted,ct); if(shift is null)return BadRequest(new{isSuccess=false,errors=new[]{"Önce kasa vardiyasını açın."}});
        var type=request.Type=="Expense"?"Expense":"Income"; if(type=="Income")shift.CashIncome+=request.Amount;else shift.CashExpense+=request.Amount;
        _db.ReceptionCashTransactions.Add(new ReceptionCashTransaction{ReceptionCashShiftId=shift.Id,Type=type,Amount=request.Amount,Description=request.Description.Trim(),PaymentMethod=request.PaymentMethod??"Cash",GuestStayId=request.GuestStayId}); AddAudit(context,"CashTransactionAdded",nameof(ReceptionCashShift),shift.Id,$"{type} {request.Amount:N2}"); await _db.SaveChangesAsync(ct); return Ok(new{isSuccess=true});
    }

    /// <summary>
    /// CloseCashShift işlemini gerçekleştirir.
    /// </summary>
[HttpPost("cash/close")]
    public async Task<IActionResult> CloseCashShift([FromBody]CloseCashShiftRequest request,CancellationToken ct)
    {
        var context=await ResolveContextAsync(request.HotelId,ct); if(context is null)return Forbid(); var shift=await _db.ReceptionCashShifts.FirstOrDefaultAsync(x=>x.HotelId==context.HotelId&&x.UserId==context.UserId&&x.Status=="Open"&&!x.IsDeleted,ct); if(shift is null)return NotFound();
        shift.CountedBalance=request.CountedBalance;shift.ClosingNote=request.Note?.Trim();shift.ClosedAt=DateTime.UtcNow;shift.Status="Closed"; AddAudit(context,"CashShiftClosed",nameof(ReceptionCashShift),shift.Id,$"Fark: {request.CountedBalance-(shift.OpeningBalance+shift.CashIncome-shift.CashExpense):N2}"); await _db.SaveChangesAsync(ct); return Ok(new{isSuccess=true});
    }

    /// <summary>
    /// AddFolioAdjustment işlemini gerçekleştirir.
    /// </summary>
[HttpPost("stays/{id:int}/folio-adjustment")]
    public async Task<IActionResult> AddFolioAdjustment(int id,[FromBody]FolioAdjustmentRequest request,CancellationToken ct)
    {
        var context=await ResolveContextAsync(request.HotelId,ct);if(context is null)return Forbid();var stay=await _db.GuestStays.FirstOrDefaultAsync(x=>x.Id==id&&x.HotelId==context.HotelId&&!x.IsDeleted,ct);if(stay is null)return NotFound();if(request.Amount<=0||string.IsNullOrWhiteSpace(request.Description))return BadRequest(new{isSuccess=false,errors=new[]{"Tutar ve açıklama zorunludur."}});
        var signed=request.Type=="Discount"?-request.Amount:request.Amount;_db.Charges.Add(new Charge{GuestStayId=id,Description=request.Description.Trim(),Amount=signed,CurrencyCode=stay.CurrencyCode,IsPostedToRoom=true,PostedToRoomAt=DateTime.UtcNow,Status=ChargeStatusEnum.Paid});AddAudit(context,"FolioAdjusted",nameof(GuestStay),id,$"{request.Type} {request.Amount:N2}");await _db.SaveChangesAsync(ct);return Ok(new{isSuccess=true});
    }

    private async Task<ReceptionContextDto?> ResolveContextAsync(int? requestedHotelId, CancellationToken ct)
    {
        var rawId = User.FindFirst("Id")?.Value ?? User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (!int.TryParse(rawId, out var userId)) return null;
        var employee = await _db.Employee.AsNoTracking().Include(x => x.Hotel).FirstOrDefaultAsync(x => x.UserId == userId && !x.IsDeleted, ct);
        var hotelId = employee?.HotelId;
        if (User.IsInRole("SystemAdmin") && requestedHotelId > 0) hotelId = requestedHotelId;
        if (!hotelId.HasValue) return null;
        var hotelName = employee?.Hotel?.Name ?? await _db.Hotel.Where(x => x.Id == hotelId).Select(x => x.Name).FirstOrDefaultAsync(ct) ?? "Otel";
        return new ReceptionContextDto(userId, hotelId.Value, hotelName, employee is null ? User.Identity?.Name ?? "Kullanıcı" : $"{employee.Name} {employee.Surname}".Trim());
    }

    private void AddAudit(ReceptionContextDto context, string action, string entityType, int? entityId, string? details) =>
        _db.ReceptionAuditLogs.Add(new ReceptionAuditLog { HotelId = context.HotelId, UserId = context.UserId, Action = action, EntityType = entityType, EntityId = entityId, Details = details });

    private static string GuestName(GuestStay stay)
    {
        var guest = stay.PrimaryCustomerId.HasValue ? stay.Customers.FirstOrDefault(x => x.Id == stay.PrimaryCustomerId) : stay.Customers.FirstOrDefault();
        return guest is null ? "Misafir" : $"{guest.Name} {guest.SurName}".Trim();
    }

    private static string CreateToken(string prefix) => $"{prefix}_{Convert.ToBase64String(RandomNumberGenerator.GetBytes(32)).Replace("+", "-").Replace("/", "_").TrimEnd('=')}";
}
/// <summary>
/// ReceptionContextDto kayıt türünü temsil eder.
/// </summary>
public record ReceptionContextDto(int UserId, int HotelId, string HotelName, string UserName);
/// <summary>
/// HotelScopedRequest sınıfını temsil eder.
/// </summary>
public class HotelScopedRequest
{
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int? HotelId { get; set; }
}

/// <summary>
/// CreateShiftNoteRequest sınıfını temsil eder.
/// </summary>
public class CreateShiftNoteRequest : HotelScopedRequest
{
/// <summary>
/// Content değerini alır veya ayarlar.
/// </summary>
public string Content { get; set; } = string.Empty;

/// <summary>
/// Priority değerini alır veya ayarlar.
/// </summary>
public string Priority { get; set; } = "Normal";
}

/// <summary>
/// ResolveShiftNoteRequest sınıfını temsil eder.
/// </summary>
public class ResolveShiftNoteRequest : HotelScopedRequest
{
/// <summary>
/// IsResolved değerini alır veya ayarlar.
/// </summary>
public bool IsResolved { get; set; } = true;
}

/// <summary>
/// ExtendStayRequest sınıfını temsil eder.
/// </summary>
public class ExtendStayRequest : HotelScopedRequest
{
/// <summary>
/// NewCheckOutDate değerini alır veya ayarlar.
/// </summary>
public DateTime NewCheckOutDate { get; set; }

/// <summary>
/// AdditionalAmount değerini alır veya ayarlar.
/// </summary>
public decimal AdditionalAmount { get; set; }

/// <summary>
/// IsLateCheckOut değerini alır veya ayarlar.
/// </summary>
public bool IsLateCheckOut { get; set; }
}

/// <summary>
/// MoveRoomRequest sınıfını temsil eder.
/// </summary>
public class MoveRoomRequest : HotelScopedRequest
{
/// <summary>
/// TargetRoomId değerini alır veya ayarlar.
/// </summary>
public int TargetRoomId { get; set; }

/// <summary>
/// Reason değerini alır veya ayarlar.
/// </summary>
public string Reason { get; set; } = string.Empty;
}

/// <summary>
/// CreateReservationRequest sınıfını temsil eder.
/// </summary>
public class CreateReservationRequest : HotelScopedRequest
{
/// <summary>
/// RoomId değerini alır veya ayarlar.
/// </summary>
public int RoomId { get; set; }

/// <summary>
/// ReservationNo değerini alır veya ayarlar.
/// </summary>
public string? ReservationNo { get; set; }

/// <summary>
/// Channel değerini alır veya ayarlar.
/// </summary>
public string? Channel { get; set; }

/// <summary>
/// GuestName değerini alır veya ayarlar.
/// </summary>
public string GuestName { get; set; } = "";

/// <summary>
/// GuestSurname değerini alır veya ayarlar.
/// </summary>
public string GuestSurname { get; set; } = "";

/// <summary>
/// Phone değerini alır veya ayarlar.
/// </summary>
public string? Phone { get; set; }

/// <summary>
/// Email değerini alır veya ayarlar.
/// </summary>
public string? Email { get; set; }

/// <summary>
/// CheckInDate değerini alır veya ayarlar.
/// </summary>
public DateTime CheckInDate { get; set; }

/// <summary>
/// CheckOutDate değerini alır veya ayarlar.
/// </summary>
public DateTime CheckOutDate { get; set; }

/// <summary>
/// AdultCount değerini alır veya ayarlar.
/// </summary>
public int AdultCount { get; set; } = 1;

/// <summary>
/// ChildCount değerini alır veya ayarlar.
/// </summary>
public int ChildCount { get; set; }

/// <summary>
/// TotalPrice değerini alır veya ayarlar.
/// </summary>
public decimal TotalPrice { get; set; }

/// <summary>
/// CurrencyCode değerini alır veya ayarlar.
/// </summary>
public string? CurrencyCode { get; set; }

/// <summary>
/// SpecialRequests değerini alır veya ayarlar.
/// </summary>
public string? SpecialRequests { get; set; }
}

/// <summary>
/// ReservationStatusRequest sınıfını temsil eder.
/// </summary>
public class ReservationStatusRequest : HotelScopedRequest
{
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = "Reserved";
}

/// <summary>
/// HousekeepingUpdateRequest sınıfını temsil eder.
/// </summary>
public class HousekeepingUpdateRequest : HotelScopedRequest
{
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = "Cleaning";

/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }

/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int? EmployeeId { get; set; }
}

/// <summary>
/// OpenCashShiftRequest sınıfını temsil eder.
/// </summary>
public class OpenCashShiftRequest : HotelScopedRequest
{
/// <summary>
/// OpeningBalance değerini alır veya ayarlar.
/// </summary>
public decimal OpeningBalance { get; set; }
}

/// <summary>
/// CashTransactionRequest sınıfını temsil eder.
/// </summary>
public class CashTransactionRequest : HotelScopedRequest
{
/// <summary>
/// Type değerini alır veya ayarlar.
/// </summary>
public string Type { get; set; } = "Income";

/// <summary>
/// Amount değerini alır veya ayarlar.
/// </summary>
public decimal Amount { get; set; }

/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; set; } = "";

/// <summary>
/// PaymentMethod değerini alır veya ayarlar.
/// </summary>
public string? PaymentMethod { get; set; }

/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int? GuestStayId { get; set; }
}

/// <summary>
/// CloseCashShiftRequest sınıfını temsil eder.
/// </summary>
public class CloseCashShiftRequest : HotelScopedRequest
{
/// <summary>
/// CountedBalance değerini alır veya ayarlar.
/// </summary>
public decimal CountedBalance { get; set; }

/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
}

/// <summary>
/// FolioAdjustmentRequest sınıfını temsil eder.
/// </summary>
public class FolioAdjustmentRequest : HotelScopedRequest
{
/// <summary>
/// Type değerini alır veya ayarlar.
/// </summary>
public string Type { get; set; } = "Charge";

/// <summary>
/// Amount değerini alır veya ayarlar.
/// </summary>
public decimal Amount { get; set; }

/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; set; } = "";
}

