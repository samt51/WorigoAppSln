using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    public class Connection : EntityBase
    {
        public Connection()
        {

        }
        public string Name { get; set; }
        public int? FlootNo { get; set; }
        public Connection(int id, string name, int? flootNo)
        {
            this.Name = name;
            this.Id = id;
            this.FlootNo = flootNo;
        }
    }
}
