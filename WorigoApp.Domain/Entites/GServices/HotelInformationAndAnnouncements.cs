using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// OTEL BİLGİ VE DUYURULAR
    /// </summary>
    public class HotelInformationAndAnnouncements : EntityBase
    {
        //İSİM,RESİM,AÇIKLAMA,DATETİME
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public HotelInformationAndAnnouncements(int id, string name, string imageUrl, string description, DateTime date)
        {
            this.Id = id;
            this.Name = name;
            this.ImageUrl = imageUrl;
            this.Description = description;
            this.Date = date;
        }
    }
}
