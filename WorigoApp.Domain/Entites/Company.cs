using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Company : EntityBase
    {
        public Company()
        {

        }
        public string Name { get; set; }
        public IList<Hotel> Hotels { get; set; }
        public Company(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
