using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Roles : EntityBase
    {
        public Roles()
        {

        }
        public Roles(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
        public string Name { get; set; }
        public IList<Users> Users { get; set; }
    }
}
