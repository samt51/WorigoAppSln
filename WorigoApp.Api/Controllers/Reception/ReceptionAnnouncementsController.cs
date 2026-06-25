using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Reception
{
    /// <summary>
    /// ReceptionAnnouncementsController sınıfını temsil eder.
    /// </summary>
[ApiController]
    [Authorize(Roles = "SystemAdmin,HotelAdmin,Management,DepartmentManager,Employee")]
    [Route("api/reception/announcements")]
    public class ReceptionAnnouncementsController : ControllerBase
    {
        private static readonly HashSet<string> AllowedImageExtensions = new(StringComparer.OrdinalIgnoreCase)
        {
            ".jpg", ".jpeg", ".png", ".webp"
        };

        private readonly AppDbContext _dbContext;
        private readonly IWebHostEnvironment _environment;
/// <summary>
/// ReceptionAnnouncementsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public ReceptionAnnouncementsController(AppDbContext dbContext, IWebHostEnvironment environment)
        {
            _dbContext = dbContext;
            _environment = environment;
        }

        /// <summary>
        /// Get işlemini gerçekleştirir.
        /// </summary>
[HttpGet]
        public async Task<ResponseDto<IList<ReceptionAnnouncementResponse>>> Get(
            [FromQuery] int hotelId,
            CancellationToken cancellationToken)
        {
            if (hotelId <= 0)
            {
                return new ResponseDto<IList<ReceptionAnnouncementResponse>>().Fail("HotelId zorunludur.", 400);
            }

            var announcements = await _dbContext.Announcements
                .AsNoTracking()
                .Where(x => x.HotelId == hotelId && !x.IsDeleted)
                .OrderByDescending(x => x.IsPinned)
                .ThenByDescending(x => x.StartAt)
                .ToListAsync(cancellationToken);

            return new ResponseDto<IList<ReceptionAnnouncementResponse>>()
                .Success(announcements.Select(ToResponse).ToList());
        }

        /// <summary>
        /// Create işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<ResponseDto<ReceptionAnnouncementResponse>> Create(
            [FromForm] ReceptionAnnouncementUpsertRequest request,
            CancellationToken cancellationToken)
        {
            var validationError = await ValidateRequestAsync(request, cancellationToken);
            if (validationError is not null)
            {
                return new ResponseDto<ReceptionAnnouncementResponse>().Fail(validationError, 400);
            }

            var announcement = new Announcement
            {
                HotelId = request.HotelId,
                Title = request.Title.Trim(),
                Description = request.Description.Trim(),
                ImageUrl = await SaveImageAsync(request.Image, cancellationToken),
                Type = ResolveType(request.Type),
                StartAt = request.StartAt ?? DateTime.UtcNow,
                EndAt = request.EndAt,
                Location = NormalizeOptional(request.Location),
                AudienceType = NormalizeOptional(request.AudienceType) ?? "AllGuests",
                IsPinned = request.IsPinned,
                IsVisibleToGuest = request.IsVisibleToGuest,
                IsActive = true
            };

            await _dbContext.Announcements.AddAsync(announcement, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return new ResponseDto<ReceptionAnnouncementResponse>().Success(ToResponse(announcement));
        }

        /// <summary>
        /// Update işlemini gerçekleştirir.
        /// </summary>
[HttpPut("{id:int}")]
        [Consumes("multipart/form-data")]
        public async Task<ResponseDto<ReceptionAnnouncementResponse>> Update(
            int id,
            [FromForm] ReceptionAnnouncementUpsertRequest request,
            CancellationToken cancellationToken)
        {
            var validationError = await ValidateRequestAsync(request, cancellationToken);
            if (validationError is not null)
            {
                return new ResponseDto<ReceptionAnnouncementResponse>().Fail(validationError, 400);
            }

            var announcement = await _dbContext.Announcements
                .FirstOrDefaultAsync(x => x.Id == id && x.HotelId == request.HotelId && !x.IsDeleted, cancellationToken);

            if (announcement is null)
            {
                return new ResponseDto<ReceptionAnnouncementResponse>().Fail("Duyuru bulunamadi.", 404);
            }

            announcement.Title = request.Title.Trim();
            announcement.Description = request.Description.Trim();
            announcement.Type = ResolveType(request.Type);
            announcement.StartAt = request.StartAt ?? announcement.StartAt;
            announcement.EndAt = request.EndAt;
            announcement.Location = NormalizeOptional(request.Location);
            announcement.AudienceType = NormalizeOptional(request.AudienceType) ?? "AllGuests";
            announcement.IsPinned = request.IsPinned;
            announcement.IsVisibleToGuest = request.IsVisibleToGuest;
            announcement.IsActive = request.IsActive;
            announcement.ModifyDate = DateTime.Now;

            if (request.Image is not null)
            {
                DeleteLocalImage(announcement.ImageUrl);
                announcement.ImageUrl = await SaveImageAsync(request.Image, cancellationToken);
            }

            await _dbContext.SaveChangesAsync(cancellationToken);
            return new ResponseDto<ReceptionAnnouncementResponse>().Success(ToResponse(announcement));
        }

        /// <summary>
        /// Delete işlemini gerçekleştirir.
        /// </summary>
[HttpDelete("{id:int}")]
        public async Task<ResponseDto<bool>> Delete(int id, [FromQuery] int hotelId, CancellationToken cancellationToken)
        {
            var announcement = await _dbContext.Announcements
                .FirstOrDefaultAsync(x => x.Id == id && x.HotelId == hotelId && !x.IsDeleted, cancellationToken);

            if (announcement is null)
            {
                return new ResponseDto<bool>().Fail("Duyuru bulunamadi.", 404);
            }

            announcement.IsDeleted = true;
            announcement.IsActive = false;
            announcement.ModifyDate = DateTime.Now;
            await _dbContext.SaveChangesAsync(cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }

        private async Task<string?> ValidateRequestAsync(ReceptionAnnouncementUpsertRequest request, CancellationToken cancellationToken)
        {
            if (request.HotelId <= 0)
            {
                return "HotelId zorunludur.";
            }

            if (!await _dbContext.Set<Hotel>().AnyAsync(x => x.Id == request.HotelId && !x.IsDeleted, cancellationToken))
            {
                return "Otel bulunamadi.";
            }

            if (string.IsNullOrWhiteSpace(request.Title))
            {
                return "Duyuru basligi zorunludur.";
            }

            if (string.IsNullOrWhiteSpace(request.Description))
            {
                return "Duyuru aciklamasi zorunludur.";
            }

            if (!request.StartAt.HasValue)
            {
                return "Duyuru baslangic tarihi ve saati zorunludur.";
            }

            if (!request.EndAt.HasValue)
            {
                return "Duyuru bitis tarihi ve saati zorunludur.";
            }

            if (request.EndAt <= request.StartAt)
            {
                return "Bitis tarihi baslangic tarihinden sonra olmalidir.";
            }

            if (request.Image is not null)
            {
                var extension = Path.GetExtension(request.Image.FileName);
                if (!AllowedImageExtensions.Contains(extension))
                {
                    return "Gorsel formati jpg, jpeg, png veya webp olmalidir.";
                }

                if (request.Image.Length > 5 * 1024 * 1024)
                {
                    return "Gorsel boyutu en fazla 5 MB olabilir.";
                }
            }

            return null;
        }

        private async Task<string?> SaveImageAsync(IFormFile? image, CancellationToken cancellationToken)
        {
            if (image is null || image.Length == 0)
            {
                return null;
            }

            var extension = Path.GetExtension(image.FileName).ToLowerInvariant();
            var fileName = $"{Guid.NewGuid():N}{extension}";
            var webRootPath = _environment.WebRootPath ?? Path.Combine(_environment.ContentRootPath, "wwwroot");
            var relativeDirectory = Path.Combine("images", "duyurular");
            var directory = Path.Combine(webRootPath, relativeDirectory);
            Directory.CreateDirectory(directory);

            await using var stream = System.IO.File.Create(Path.Combine(directory, fileName));
            await image.CopyToAsync(stream, cancellationToken);

            return $"/images/duyurular/{fileName}";
        }

        private void DeleteLocalImage(string? imageUrl)
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
            {
                return;
            }

            var pathPrefix = imageUrl.StartsWith("/images/duyurular/", StringComparison.OrdinalIgnoreCase)
                ? Path.Combine("images", "duyurular")
                : imageUrl.StartsWith("/uploads/announcements/", StringComparison.OrdinalIgnoreCase)
                    ? Path.Combine("uploads", "announcements")
                    : null;

            if (pathPrefix is null)
            {
                return;
            }

            var fileName = Path.GetFileName(imageUrl);
            var webRootPath = _environment.WebRootPath ?? Path.Combine(_environment.ContentRootPath, "wwwroot");
            var path = Path.Combine(webRootPath, pathPrefix, fileName);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }

        private static AnnouncementTypeEnum ResolveType(int type)
        {
            return Enum.IsDefined(typeof(AnnouncementTypeEnum), type)
                ? (AnnouncementTypeEnum)type
                : AnnouncementTypeEnum.Announcement;
        }

        private static string? NormalizeOptional(string? value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }

        private ReceptionAnnouncementResponse ToResponse(Announcement announcement)
        {
            return new ReceptionAnnouncementResponse
            {
                Id = announcement.Id,
                HotelId = announcement.HotelId,
                Title = announcement.Title,
                Description = announcement.Description,
                ImageUrl = BuildAbsoluteUrl(announcement.ImageUrl),
                Type = announcement.Type.ToString(),
                TypeValue = (int)announcement.Type,
                StartAt = announcement.StartAt,
                EndAt = announcement.EndAt,
                Location = announcement.Location,
                AudienceType = announcement.AudienceType,
                IsPinned = announcement.IsPinned,
                IsVisibleToGuest = announcement.IsVisibleToGuest,
                IsActive = announcement.IsActive
            };
        }

        private string? BuildAbsoluteUrl(string? path)
        {
            if (string.IsNullOrWhiteSpace(path) || Uri.TryCreate(path, UriKind.Absolute, out _))
            {
                return path;
            }

            return $"{Request.Scheme}://{Request.Host}{path}";
        }
    }

/// <summary>
/// ReceptionAnnouncementUpsertRequest sınıfını temsil eder.
/// </summary>
public class ReceptionAnnouncementUpsertRequest
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; set; } = string.Empty;
/// <summary>
/// Type değerini alır veya ayarlar.
/// </summary>
public int Type { get; set; } = 1;
/// <summary>
/// StartAt değerini alır veya ayarlar.
/// </summary>
public DateTime? StartAt { get; set; }
/// <summary>
/// EndAt değerini alır veya ayarlar.
/// </summary>
public DateTime? EndAt { get; set; }
/// <summary>
/// Location değerini alır veya ayarlar.
/// </summary>
public string? Location { get; set; }
/// <summary>
/// AudienceType değerini alır veya ayarlar.
/// </summary>
public string? AudienceType { get; set; }
/// <summary>
/// IsPinned değerini alır veya ayarlar.
/// </summary>
public bool IsPinned { get; set; }
/// <summary>
/// IsVisibleToGuest değerini alır veya ayarlar.
/// </summary>
public bool IsVisibleToGuest { get; set; } = true;
/// <summary>
/// IsActive değerini alır veya ayarlar.
/// </summary>
public bool IsActive { get; set; } = true;
/// <summary>
/// Image değerini alır veya ayarlar.
/// </summary>
public IFormFile? Image { get; set; }
    }

/// <summary>
/// ReceptionAnnouncementResponse sınıfını temsil eder.
/// </summary>
public class ReceptionAnnouncementResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; set; } = string.Empty;
/// <summary>
/// ImageUrl değerini alır veya ayarlar.
/// </summary>
public string? ImageUrl { get; set; }
/// <summary>
/// Type değerini alır veya ayarlar.
/// </summary>
public string Type { get; set; } = string.Empty;
/// <summary>
/// TypeValue değerini alır veya ayarlar.
/// </summary>
public int TypeValue { get; set; }
/// <summary>
/// StartAt değerini alır veya ayarlar.
/// </summary>
public DateTime StartAt { get; set; }
/// <summary>
/// EndAt değerini alır veya ayarlar.
/// </summary>
public DateTime? EndAt { get; set; }
/// <summary>
/// Location değerini alır veya ayarlar.
/// </summary>
public string? Location { get; set; }
/// <summary>
/// AudienceType değerini alır veya ayarlar.
/// </summary>
public string? AudienceType { get; set; }
/// <summary>
/// IsPinned değerini alır veya ayarlar.
/// </summary>
public bool IsPinned { get; set; }
/// <summary>
/// IsVisibleToGuest değerini alır veya ayarlar.
/// </summary>
public bool IsVisibleToGuest { get; set; }
/// <summary>
/// IsActive değerini alır veya ayarlar.
/// </summary>
public bool IsActive { get; set; }
    }
}
