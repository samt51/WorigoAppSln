using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    public class TravelOrTransportation : EntityBase
    {
        /// <summary>
        ///  Bu alan, ulaşım hizmetinin türünü belirtir. örn:Havaalanı Transferi
        /// </summary>
        public string TransportationType { get; set; }
        /// <summary>
        /// Bu alan, ulaşımın hedef adresini belirtir. 
        /// </summary>
        public string TransportationAddress { get; set; }
        /// <summary>
        /// Ulaşım Türü
        /// </summary>
        public string TransportationVehicle { get; set; }
        /// <summary>
        /// randevu tarihi.
        /// </summary>
        public DateTime RequestDate { get; set; }
    }
}
