using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Users : EntityBase
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Employee Employee { get; }
        public int RoleId { get; set; }
        public Roles Role { get; set; }
    }
}
