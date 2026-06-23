using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Sisteme giriş yapabilen kullanıcı hesabını tutar.
    /// </summary>
    public class Users : EntityBase
    {
        public Users()
        {
        }

        /// <summary>
        /// Kullanıcının e-posta adresi.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Kullanıcı şifresinin hashlenmiş değeri.
        /// </summary>
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// Girişte kullanılabilecek kullanıcı adı.
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// Kullanıcının tercih ettiği dil.
        /// </summary>
        public string PreferredLanguageCode { get; set; } = "tr-TR";

        /// <summary>
        /// Son başarılı giriş zamanı.
        /// </summary>
        public DateTime? LastLoginAt { get; set; }

        /// <summary>
        /// Başarısız giriş deneme sayısı.
        /// </summary>
        public int FailedLoginCount { get; set; }

        /// <summary>
        /// Hesap geçici olarak kilitli mi?
        /// </summary>
        public bool IsLocked { get; set; }

        /// <summary>
        /// Refresh token değeri.
        /// </summary>
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Refresh token bitiş tarihi.
        /// </summary>
        public DateTime? RefreshTokenExpireDate { get; set; }

        public Employee? Employee { get; set; }
        public int RoleId { get; set; }
        public Roles Role { get; set; } = null!;
        public IList<ConversationMessage> ConversationMessages { get; set; } = new List<ConversationMessage>();
        public IList<ServiceRequestHistory> ServiceRequestHistories { get; set; } = new List<ServiceRequestHistory>();

        public Users(int Id, string email, string password, int roleId)
        {
            this.Id = Id;
            Email = email;
            Password = password;
            RoleId = roleId;
        }
    }
}
