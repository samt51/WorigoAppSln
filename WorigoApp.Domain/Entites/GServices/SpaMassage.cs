using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    public class SpaMassage : EntityBase
    {
        public SpaMassage()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<SpaMassageValue> SpaMassageValues { get; set; }
        public SpaMassage(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
    public class SpaMassageValue : EntityBase
    {
        public SpaMassageValue()
        {

        }
        public string Value { get; set; }
        public int SpaMassageId { get; set; }
        public decimal Price { get; set; }
        public SpaMassage SpaMassage { get; set; }
        public SpaMassageValue(int id, string value, int spaMassageId)
        {
            this.Id = id;
            this.Value = value;
            this.SpaMassageId = spaMassageId;
        }
    }
}
