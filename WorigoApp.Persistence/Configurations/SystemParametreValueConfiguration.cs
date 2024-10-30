using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class SystemParametreValueConfiguration : IEntityTypeConfiguration<SystemParametreValues>
    {
        public void Configure(EntityTypeBuilder<SystemParametreValues> builder)
        {
            #region PriceStatus
            var priceStatus = new SystemParametreValues(1, 1, "₺", 1, "Türk Lirası");
            var priceStatus2 = new SystemParametreValues(2, 1, "$", 2, "Dolar");
            var priceStatus3 = new SystemParametreValues(3, 1, "€", 3, "Euro");

            #endregion

            #region OrderStatus
            var orderStatus2 = new SystemParametreValues(5, 2, "Preparing", 1);
            var orderStatus3 = new SystemParametreValues(6, 2, "IsComing", 2);
            var orderStatus4 = new SystemParametreValues(7, 2, "Delivered", 3);
            #endregion

            #region RoomFoodTypeStatus
            var roomFoodType = new SystemParametreValues(8, 3, "Breakfast", 1);
            var roomFoodType2 = new SystemParametreValues(9, 3, "HalfPension", 2);
            var roomFoodType3 = new SystemParametreValues(10, 3, "FullPension", 3);
            var roomFoodType4 = new SystemParametreValues(11, 3, "AllInclusive", 4);
            var roomFoodType5 = new SystemParametreValues(12, 3, "UltraAllInclusive", 5);


            #endregion

            #region RoomTypeStatus
            var roomType = new SystemParametreValues(13, 4, "Standart", 1);
            var roomType2 = new SystemParametreValues(14, 4, "SingleRoom", 2);
            var roomType3 = new SystemParametreValues(15, 4, "DoubleRoom", 3);
            var roomType4 = new SystemParametreValues(16, 4, "SuitRoom", 4);

            #endregion

            #region ServiceStatus
            var serviceStatus = new SystemParametreValues(17, 5, "Menu", 1);
            var serviceStatus2 = new SystemParametreValues(18, 5, "TechnicalNeed", 2);
            var serviceStatus3 = new SystemParametreValues(19, 5, "BellBoy", 3);
            var serviceStatus4 = new SystemParametreValues(20, 5, "Connection", 4);
            var serviceStatus5 = new SystemParametreValues(21, 5, "DryCleaner", 5);
            var serviceStatus6 = new SystemParametreValues(22, 5, "HouseKeeping", 6);
            var serviceStatus7 = new SystemParametreValues(23, 5, "SpaMessage", 7);
            var serviceStatus8 = new SystemParametreValues(24, 5, "HealthAndSafety", 8);
            var serviceStatus9 = new SystemParametreValues(25, 5, "TravelOrTransportation", 9);

            #endregion

            #region StatusType
            var statusType3 = new SystemParametreValues(28, 6, "Waiting", 1);
            var statusType = new SystemParametreValues(26, 6, "Proccess", 2);
            var statusType2 = new SystemParametreValues(27, 6, "Completed", 3);

            #endregion

            #region TypesOfHealthAndSports
            var typeOfHealthAndSports = new SystemParametreValues(29, 7, "Spa", 1);
            var typeOfHealthAndSports2 = new SystemParametreValues(30, 7, "Massage", 2);
            var typeOfHealthAndSports3 = new SystemParametreValues(31, 7, "Fitness", 3);
            var typeOfHealthAndSports4 = new SystemParametreValues(32, 7, "Poor", 4);
            #endregion


            builder.HasData(priceStatus, priceStatus2, priceStatus3, orderStatus2, orderStatus3, orderStatus4,
                roomFoodType, roomFoodType2, roomFoodType3, roomFoodType4, roomFoodType5, roomType, roomType2, roomType3, roomType4
                , serviceStatus, serviceStatus2, serviceStatus3, serviceStatus4, serviceStatus5, serviceStatus6, serviceStatus7, serviceStatus8
                , serviceStatus9,
                statusType, statusType2, statusType3, typeOfHealthAndSports, typeOfHealthAndSports2, typeOfHealthAndSports3
                , typeOfHealthAndSports4);
        }
    }
}
