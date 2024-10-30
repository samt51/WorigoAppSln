using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class SystemParametre : IEntityBase
    {
        public int Id { get; set; }
        public string ParametreKey { get; set; }
        public bool IsDeleted { get; set; } = false;
        public IList<SystemParametreValues> SystemParametreValues { get; set; }

        public SystemParametre()
        {

        }
        public SystemParametre(int id, string parametreKey)
        {
            this.Id = id;
            this.ParametreKey = parametreKey;
        }
    }
}
