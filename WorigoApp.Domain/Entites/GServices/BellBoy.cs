using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    //bu kalkacak
    public class BellBoy : EntityBase
    {
        public BellBoy()
        {

        }
        public string Name { get; set; }
        public BellBoy(int id,string name)
        {
            this.Name = name;
            this.Id = id;   
        }
    }
}
