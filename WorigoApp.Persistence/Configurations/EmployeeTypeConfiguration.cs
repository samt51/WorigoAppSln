using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class EmployeeTypeConfiguration : IEntityTypeConfiguration<EmployeeType>
    {
        public void Configure(EntityTypeBuilder<EmployeeType> builder)
        {
            #region ÖnBüroResepsiyonDepartmanı
            var employeeType1 = new EmployeeType(1, "Ön Büro Müdürü", 1);
            var employeeType2 = new EmployeeType(2, "Gece Müdürü", 1);
            var employeeType3 = new EmployeeType(3, "Ön Büro Şefi", 1);
            var employeeType4 = new EmployeeType(4, "Resepsiyonist", 1);
            var employeeType5 = new EmployeeType(5, "Concierge Şefi", 1);
            var employeeType6 = new EmployeeType(6, "Taşıyıcı/Karşılayıcı Personel", 1);
            var employeeType7 = new EmployeeType(7, "Guest Service Agent", 1);
            var employeeType8 = new EmployeeType(8, "Guest Relation", 1);
            #endregion

            #region HousekeepingDepartmanı

            var houseKeepingDepEmployeeType = new EmployeeType(9, "HK Müdürü", 2);
            var houseKeepingDepEmployeeType2 = new EmployeeType(10, "Housekeeper", 2);
            var houseKeepingDepEmployeeType3 = new EmployeeType(11, "Kat Şefi (Floor Supervisor)", 2);
            var houseKeepingDepEmployeeType4 = new EmployeeType(12, "Oda Görevlisi", 2);
            var houseKeepingDepEmployeeType5 = new EmployeeType(13, "Meydancı", 2);
            #endregion

            #region YiyecekİçecekveMutfakDepartmanı
            var foodandDrinkDepEmployeeType = new EmployeeType(14, "Yiyecek – İçecek Müdürü", 3);
            var foodandDrinkDepEmployeeType2 = new EmployeeType(15, "Barlar Şefi", 3);
            var foodandDrinkDepEmployeeType3 = new EmployeeType(16, "Bar Personeli", 3);
            var foodandDrinkDepEmployeeType4 = new EmployeeType(17, "Mutfak Şefi", 3);
            var foodandDrinkDepEmployeeType5 = new EmployeeType(18, "Mutfak Personeli", 3);
            var foodandDrinkDepEmployeeType6 = new EmployeeType(19, "Restoran Şefi", 3);
            var foodandDrinkDepEmployeeType7 = new EmployeeType(20, "Servis Personeli", 3);
            #endregion

            #region TecnichalNeedDepartment
            var tecnicalneedDepEmployeeType = new EmployeeType(21, "Teknik Müdür", 4);
            var tecnicalneedDepEmployeeType2 = new EmployeeType(22, "Elektrik Tekniker", 4);
            var tecnicalneedDepEmployeeType3 = new EmployeeType(23, "Mekanik Tekniker", 4);
            var tecnicalneedDepEmployeeType4 = new EmployeeType(24, "Tesisatçı", 4);
            #endregion

            #region SpaHealthClubDepartment
            var spaEmployeeType = new EmployeeType(25, "Masör", 5);
            #endregion

            builder.HasData(employeeType1, employeeType2, employeeType3, employeeType4, employeeType5, employeeType6, employeeType7, employeeType8
                , houseKeepingDepEmployeeType, houseKeepingDepEmployeeType2, houseKeepingDepEmployeeType3, houseKeepingDepEmployeeType4, houseKeepingDepEmployeeType5,
               foodandDrinkDepEmployeeType, foodandDrinkDepEmployeeType2, foodandDrinkDepEmployeeType3, foodandDrinkDepEmployeeType4, foodandDrinkDepEmployeeType5, foodandDrinkDepEmployeeType6,
               foodandDrinkDepEmployeeType7, tecnicalneedDepEmployeeType, tecnicalneedDepEmployeeType2, tecnicalneedDepEmployeeType3, tecnicalneedDepEmployeeType4, spaEmployeeType);


        }
    }
}
