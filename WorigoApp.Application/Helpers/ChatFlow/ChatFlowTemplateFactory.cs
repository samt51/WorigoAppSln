using System.Text.Json;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Helpers.ChatFlow
{
    /// <summary>
    /// ChatFlowTemplateFactory sınıfını temsil eder.
    /// </summary>
    public static class ChatFlowTemplateFactory
    {
/// <summary>
/// ResolveUiType işlemini gerçekleştirir.
/// </summary>
public static ServiceFlowUiTypeEnum ResolveUiType(string serviceType, string? categoryName = null)
        {
            if (serviceType == ServicesEnum.Menu.ToString() || serviceType == ServicesEnum.Minibar.ToString())
            {
                return ServiceFlowUiTypeEnum.Menu;
            }

            if (serviceType == ServicesEnum.HouseKeeping.ToString() || serviceType == ServicesEnum.AmenityRequest.ToString())
            {
                return ServiceFlowUiTypeEnum.QuickOption;
            }

            if (serviceType == ServicesEnum.HealthAndSafety.ToString() && IsInformationCategory(categoryName))
            {
                return ServiceFlowUiTypeEnum.InfoCard;
            }

            if (serviceType == ServicesEnum.BellBoy.ToString() || serviceType == ServicesEnum.Connection.ToString())
            {
                return ServiceFlowUiTypeEnum.DirectChat;
            }

            return ServiceFlowUiTypeEnum.Form;
        }
/// <summary>
/// ResolveOpeningMessageType işlemini gerçekleştirir.
/// </summary>
public static ConversationMessageTypeEnum ResolveOpeningMessageType(ServiceFlowUiTypeEnum uiType)
        {
            return uiType switch
            {
                ServiceFlowUiTypeEnum.Menu => ConversationMessageTypeEnum.ProductCard,
                ServiceFlowUiTypeEnum.QuickOption => ConversationMessageTypeEnum.QuickReply,
                ServiceFlowUiTypeEnum.Form => ConversationMessageTypeEnum.Form,
                ServiceFlowUiTypeEnum.InfoCard => ConversationMessageTypeEnum.OptionList,
                _ => ConversationMessageTypeEnum.Text
            };
        }
/// <summary>
/// ResolveOpeningMessage işlemini gerçekleştirir.
/// </summary>
public static string ResolveOpeningMessage(ServiceFlowUiTypeEnum uiType, string serviceType, string? categoryName = null)
        {
            return uiType switch
            {
                ServiceFlowUiTypeEnum.Menu => "Ne siparis etmek istersiniz?",
                ServiceFlowUiTypeEnum.QuickOption => "Hangi urunu istiyorsunuz?",
                ServiceFlowUiTypeEnum.Form when serviceType == ServicesEnum.TechnicalNeed.ToString() => "Sorununuz nedir?",
                ServiceFlowUiTypeEnum.Form => "Talebiniz icin gerekli bilgileri alalim.",
                ServiceFlowUiTypeEnum.InfoCard => "Hangi konuda bilgi almak istersiniz?",
                _ => "Merhaba, size nasil yardimci olabilirim?"
            };
        }
 /// <summary>
 /// BuildOpeningPayloadJson işlemini gerçekleştirir.
 /// </summary>

        public static string BuildOpeningPayloadJson(
            ServiceFlowUiTypeEnum uiType,
            string serviceType,
            IEnumerable<(string Label, string Value)>? options = null,
            string? categoryName = null,
            string? openingMessage = null)
        {
            var optionList = options?.Where(x => !string.IsNullOrWhiteSpace(x.Label)).ToList()
                ?? new List<(string Label, string Value)>();

            if (!optionList.Any())
            {
                optionList = GetDefaultOptions(uiType, serviceType, categoryName).ToList();
            }

            var payload = new
            {
                uiType = uiType.ToString(),
                title = string.IsNullOrWhiteSpace(openingMessage)
                    ? ResolveOpeningMessage(uiType, serviceType, categoryName)
                    : openingMessage,
                options = optionList.Select(x => new
                {
                    label = x.Label,
                    value = string.IsNullOrWhiteSpace(x.Value) ? x.Label : x.Value
                })
            };

            return JsonSerializer.Serialize(payload);
        }

        private static IEnumerable<(string Label, string Value)> GetDefaultOptions(
            ServiceFlowUiTypeEnum uiType,
            string serviceType,
            string? categoryName)
        {
            if (uiType == ServiceFlowUiTypeEnum.Menu)
            {
                return new[]
                {
                    ("Pizza", "pizza"),
                    ("Burger", "burger"),
                    ("Salata", "salad"),
                    ("Icecek", "drink"),
                    ("Tatli", "dessert"),
                    ("Minibar", "minibar")
                };
            }

            if (uiType == ServiceFlowUiTypeEnum.QuickOption)
            {
                return new[]
                {
                    ("Havlu", "towel"),
                    ("Terlik", "slipper"),
                    ("Sampuan", "shampoo"),
                    ("Yastik", "pillow"),
                    ("Battaniye", "blanket"),
                    ("Diger", "other")
                };
            }

            if (uiType == ServiceFlowUiTypeEnum.InfoCard)
            {
                return new[]
                {
                    ("Wi-Fi Bilgisi", "wifi"),
                    ("Kahvalti Saatleri", "breakfast-hours"),
                    ("Havuz Saatleri", "pool-hours"),
                    ("Otel Etkinlikleri", "hotel-events"),
                    ("Otel Kurallari", "hotel-rules"),
                    ("Ulasim", "transportation"),
                    ("Diger", "other")
                };
            }

            if (serviceType == ServicesEnum.TechnicalNeed.ToString())
            {
                return new[]
                {
                    ("Klima", "air-conditioner"),
                    ("TV", "tv"),
                    ("Wi-Fi", "wifi"),
                    ("Elektrik", "electricity"),
                    ("Sicak Su", "hot-water"),
                    ("Diger", "other")
                };
            }

            return Array.Empty<(string Label, string Value)>();
        }

        private static bool IsInformationCategory(string? categoryName)
        {
            return !string.IsNullOrWhiteSpace(categoryName) &&
                   categoryName.Contains("Bilgilendirme", StringComparison.OrdinalIgnoreCase);
        }
    }
}
