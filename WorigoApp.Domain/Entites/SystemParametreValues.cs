using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class SystemParametreValues : IEntityBase
    {
        public int Id { get; set; }
        public string ParametreKey { get; set; }
        public SystemParametre SystemParametre { get; set; }
        public string ParametreValue { get; set; }
        public int ParametreValueId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
