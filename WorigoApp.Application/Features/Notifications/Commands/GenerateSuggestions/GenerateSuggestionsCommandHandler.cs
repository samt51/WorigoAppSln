using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Notifications.Dtos;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Notifications.Commands.GenerateSuggestions
{
    public class GenerateSuggestionsCommandHandler : IRequestHandler<GenerateSuggestionsCommandRequest, ResponseDto<GenerateSuggestionsResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenerateSuggestionsCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<GenerateSuggestionsResponse>> Handle(GenerateSuggestionsCommandRequest request, CancellationToken cancellationToken)
        {
            var today = DateTime.Today;
            var now = DateTime.UtcNow;

            var activeStays = await _unitOfWork.GetReadRepository<GuestStay>().GetAllAsync(
                x => x.IsActive && !x.IsDeleted && x.ActualCheckInAt != null && x.ActualCheckOutAt == null,
                include: q => q.Include(x => x.Customers).Include(x => x.GuestSessions));

            int generatedCount = 0;
            var listToBroadcast = new List<SuggestionNotificationDto>();

            foreach (var stay in activeStays)
            {
                var primaryCustomer = stay.Customers.FirstOrDefault(x => x.IsPrimaryGuest)
                                      ?? stay.Customers.FirstOrDefault();

                var activeSession = stay.GuestSessions.FirstOrDefault(x => x.IsActiveSession && !x.IsDeleted && x.ExpiresAt > now);

                if (primaryCustomer is null || activeSession is null) continue;

                // Rule 1: Welcome suggestion
                if (stay.CheckInDate.Date == today.Date)
                {
                    var exists = await _unitOfWork.GetReadRepository<GuestNotification>().FindAsync(
                        x => x.GuestStayId == stay.Id && x.NotificationType == "Welcome" && !x.IsDeleted);

                    if (exists is null)
                    {
                        var notification = new GuestNotification
                        {
                            HotelId = stay.HotelId,
                            GuestStayId = stay.Id,
                            CustomerId = primaryCustomer.Id,
                            GuestSessionId = activeSession.Id,
                            Title = "Worigo'ya Hoş Geldiniz!",
                            Message = $"Değerli misafirimiz {primaryCustomer.Name}, otelimize hoş geldiniz! Konaklamanız boyunca tüm ihtiyaçlarınız için bu uygulamayı kullanabilirsiniz.",
                            NotificationType = "Welcome",
                            IsRead = false,
                            ScheduledAt = now,
                            SentAt = now,
                            CreatedDate = DateTime.Now,
                            IsActive = true
                        };
                        await _unitOfWork.GetWriteRepository<GuestNotification>().AddAsync(notification);
                        generatedCount++;
                        listToBroadcast.Add(new SuggestionNotificationDto
                        {
                            GuestStayId = stay.Id,
                            Title = notification.Title,
                            Message = notification.Message,
                            NotificationType = notification.NotificationType,
                            SentAt = notification.SentAt
                        });
                    }
                }

                // Rule 2: SPA slot recommendation
                var spaAppts = await _unitOfWork.GetReadRepository<SpaAppointment>().GetAllAsync(
                    x => x.GuestStayId == stay.Id && x.Status != "Cancelled" && !x.IsDeleted);

                if (!spaAppts.Any())
                {
                    var exists = await _unitOfWork.GetReadRepository<GuestNotification>().FindAsync(
                        x => x.GuestStayId == stay.Id && x.NotificationType == "SpaRecommendation" && !x.IsDeleted);

                    if (exists is null)
                    {
                        var notification = new GuestNotification
                        {
                            HotelId = stay.HotelId,
                            GuestStayId = stay.Id,
                            CustomerId = primaryCustomer.Id,
                            GuestSessionId = activeSession.Id,
                            Title = "Sizi SPA Merkezimize Bekliyoruz",
                            Message = "Yoğun günlerin stresini atmak için SPA merkezimizdeki masaj ve terapi hizmetlerine göz atın. Bugün için müsait slotlarımız mevcuttur.",
                            NotificationType = "SpaRecommendation",
                            IsRead = false,
                            ScheduledAt = now,
                            SentAt = now,
                            CreatedDate = DateTime.Now,
                            IsActive = true
                        };
                        await _unitOfWork.GetWriteRepository<GuestNotification>().AddAsync(notification);
                        generatedCount++;
                        listToBroadcast.Add(new SuggestionNotificationDto
                        {
                            GuestStayId = stay.Id,
                            Title = notification.Title,
                            Message = notification.Message,
                            NotificationType = notification.NotificationType,
                            SentAt = notification.SentAt
                        });
                    }
                }

                // Rule 3: Restaurant recommendation
                var restRes = await _unitOfWork.GetReadRepository<RestaurantReservation>().GetAllAsync(
                    x => x.GuestStayId == stay.Id && x.Status != "Cancelled" && x.Status != "Rejected" && !x.IsDeleted);

                if (!restRes.Any())
                {
                    var exists = await _unitOfWork.GetReadRepository<GuestNotification>().FindAsync(
                        x => x.GuestStayId == stay.Id && x.NotificationType == "RestaurantRecommendation" && !x.IsDeleted);

                    if (exists is null)
                    {
                        var notification = new GuestNotification
                        {
                            HotelId = stay.HotelId,
                            GuestStayId = stay.Id,
                            CustomerId = primaryCustomer.Id,
                            GuestSessionId = activeSession.Id,
                            Title = "Akşam Yemeği İçin Rezervasyon Yapın",
                            Message = "A la carte restoranlarımızda lezzetli bir akşam yemeği deneyimi için hemen yerinizi ayırtın. Rezervasyon modülünden menüleri inceleyebilirsiniz.",
                            NotificationType = "RestaurantRecommendation",
                            IsRead = false,
                            ScheduledAt = now,
                            SentAt = now,
                            CreatedDate = DateTime.Now,
                            IsActive = true
                        };
                        await _unitOfWork.GetWriteRepository<GuestNotification>().AddAsync(notification);
                        generatedCount++;
                        listToBroadcast.Add(new SuggestionNotificationDto
                        {
                            GuestStayId = stay.Id,
                            Title = notification.Title,
                            Message = notification.Message,
                            NotificationType = notification.NotificationType,
                            SentAt = notification.SentAt
                        });
                    }
                }

                // Rule 4: Checkout day folyo quick checkout info
                if (stay.CheckOutDate.Date == today.Date)
                {
                    var exists = await _unitOfWork.GetReadRepository<GuestNotification>().FindAsync(
                        x => x.GuestStayId == stay.Id && x.NotificationType == "CheckoutInfo" && !x.IsDeleted);

                    if (exists is null)
                    {
                        var notification = new GuestNotification
                        {
                            HotelId = stay.HotelId,
                            GuestStayId = stay.Id,
                            CustomerId = primaryCustomer.Id,
                            GuestSessionId = activeSession.Id,
                            Title = "Hızlı Çıkış (Checkout) İşlemleri",
                            Message = "Bugün çıkış gününüz. Resepsiyonda beklememek için harcamalarınızı (folyonuzu) inceleyip mobil uygulama üzerinden hızlı çıkış yapabilirsiniz.",
                            NotificationType = "CheckoutInfo",
                            IsRead = false,
                            ScheduledAt = now,
                            SentAt = now,
                            CreatedDate = DateTime.Now,
                            IsActive = true
                        };
                        await _unitOfWork.GetWriteRepository<GuestNotification>().AddAsync(notification);
                        generatedCount++;
                        listToBroadcast.Add(new SuggestionNotificationDto
                        {
                            GuestStayId = stay.Id,
                            Title = notification.Title,
                            Message = notification.Message,
                            NotificationType = notification.NotificationType,
                            SentAt = notification.SentAt
                        });
                    }
                }
            }

            if (generatedCount > 0)
            {
                await _unitOfWork.SaveAsync(cancellationToken);
            }

            return new ResponseDto<GenerateSuggestionsResponse>().Success(new GenerateSuggestionsResponse
            {
                GeneratedCount = generatedCount,
                NotificationsToBroadcast = listToBroadcast
            });
        }
    }
}
