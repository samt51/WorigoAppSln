using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class SystemParametreValues : IEntityBase
    {
        public int Id { get; set; }
        public int SystemParametreId { get; set; }
        public SystemParametre SystemParametre { get; set; }
        public string ParametreValue { get; set; }
        public string Description { get; set; } = string.Empty;
        public int SystemParametreValueId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public SystemParametreValues()
        {

        }
        public SystemParametreValues(int id, int systemParametreId, string parametreValue, int systemParametreValueId, string description)
        {
            this.Id = id;
            this.SystemParametreId = systemParametreId;
            this.ParametreValue = parametreValue;
            this.Description = description;
            this.SystemParametreValueId = systemParametreValueId;
        }

        public SystemParametreValues(int id, int systemParametreId, string parametreValue, int systemParametreValueId)
        {
            this.Id = id;
            this.SystemParametreId = systemParametreId;
            this.ParametreValue = parametreValue;
            this.SystemParametreValueId = systemParametreValueId;
        }
    }
}
