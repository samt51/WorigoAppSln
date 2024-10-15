using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Users : EntityBase
    {
        public Users()
        {

        }
        public string Email { get; set; }
        public string Password { get; set; }
        public Employee Employee { get; }
        public int RoleId { get; set; }
        public Roles Role { get; set; }

        public Users(int Id, string email, string password, int roleId)
        {
            this.Id = Id;
            this.Email = email;
            this.Password = password;
            this.RoleId = roleId;
        }
    }
}
