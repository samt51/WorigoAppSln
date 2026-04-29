# Role Authorization Matrix

Bu dokuman, projedeki rollerin hangi modullere hangi seviyede erisecegini netlestirmek icin hazirlandi.

## Mevcut Roller

- `SystemAdmin`
- `HotelAdmin`
- `Management`
- `DepartmentManager`
- `Employee`
- `Customer`

## Onerilen Ek Roller

- `HRManager`
- `PurchasingManager`

Not:
Su an veritabanindaki `Roles` seed'inde bu iki rol yok. Ilk uygun adimda bunlarin da role seed'ine eklenmesi tavsiye edilir.

## Rol Tanimi

### `SystemAdmin`
Platformun teknik sahibi. Tum sirketleri, otelleri ve konfigurasyonu yonetir.

### `HotelAdmin`
Tek bir otelin tam yonetim yetkisine sahip kullanicisidir.

### `Management`
Otel yonetim ekibidir. Rapor, performans, operasyon ve dashboard odaklidir.

### `DepartmentManager`
Kendi departmanindaki personel, gorev, servis ve izin akisini yonetir.

### `HRManager`
IK, ozluk, evrak, izin ikinci onay ve performans sureclerini yonetir.

### `PurchasingManager`
Stok, alim, eksik urun ve satin alma taleplerini yonetir.

### `Employee`
Kendi gorevlerini, vardiyasini, izinlerini ve gerekliyse kendine atanan servisleri gorur.

### `Customer`
Sadece kendi konaklamasi ve misafir uygulamasi ozelliklerine erisir.

## Moduller ve Yetki Seviyesi

Seviye anahtari:

- `None`: Erisim yok
- `Read`: Sadece goruntuleme
- `Own`: Sadece kendine ait kayitlar
- `Department`: Kendi departmani
- `Hotel`: Kendi oteli
- `All`: Tum sistem

| Modul | SystemAdmin | HotelAdmin | Management | DepartmentManager | HRManager | PurchasingManager | Employee | Customer |
|---|---|---|---|---|---|---|---|---|
| Sirket/Otel Yonetimi | All | Hotel | Read | None | None | None | None | None |
| Departman / EmployeeType / Shift | All | Hotel | Read | Department | Read | None | None | None |
| Personel Kayitlari | All | Hotel | Read | Department | Hotel | None | Own | None |
| Oda / RoomType | All | Hotel | Read | None | None | None | None | None |
| Misafir / Check-in / Check-out | All | Hotel | Read | None | None | None | Own by employee type | None |
| Servis Kataloglari | All | Hotel | Read | Department | None | None | Read | Read |
| ServiceRequest | All | Hotel | Hotel | Department | Read | None | Own | Own |
| ServiceRequest Chat | All | Hotel | Hotel | Department | None | None | Own | Own |
| ServiceRequest Rating | All | Hotel | Hotel | Department | None | None | Read | Own |
| Siparis / Order | All | Hotel | Hotel | Department | None | None | Own | Own |
| Finans / Karlilik Raporlari | All | Hotel | Hotel | Department | None | None | None | None |
| Stok Kartlari | All | Hotel | Read | Department | None | Hotel | None | None |
| Stok Hareketleri | All | Hotel | Read | Department | None | Hotel | None | None |
| Stok Talepleri | All | Hotel | Read | Department | None | Hotel | Own | None |
| Izin Talepleri | All | Hotel | Read | Department | Hotel | Own | Own | None |
| Attendance / Mesai | All | Hotel | Hotel | Department | Hotel | None | Own | None |
| Performance Review | All | Hotel | Hotel | Department | Hotel | None | Own | None |
| Internal Announcement | All | Hotel | Hotel | Department | Hotel | Hotel | Read | None |
| Employee Task | All | Hotel | Hotel | Department | Department | None | Own | None |
| Employee Document | All | Hotel | Read | Department | Hotel | None | Own | None |
| Dashboard / Raporlar | All | Hotel | Hotel | Department | Hotel | Hotel | Own | Own |

## Ekran Bazli Onerilen Gorunum

### `SystemAdmin`

- Tum sirketler
- Tum oteller
- Rol ve sistem ayarlari
- Genel teknik log ve konfigurasyon

### `HotelAdmin`

- Otel ayarlari
- Departmanlar
- Personel
- Vardiyalar
- Servisler
- Stok
- Izin / IK
- Tum otel raporlari

### `Management`

- Dashboard
- Finans raporlari
- Departman performansi
- Personel performansi
- En cok ariza raporu
- Attendance ve task ozetleri

### `DepartmentManager`

- Kendi departman personeli
- Kendi departman service request'leri
- Kendi departman gorevleri
- Kendi departman stok talepleri
- Kendi departman izin onaylari
- Kendi departman raporlari

### `HRManager`

- Personel ozluk kayitlari
- Izin ikinci onay
- Evrak ve belge takibi
- Performans review kayitlari
- Attendance kayitlari
- IK duyurulari

### `PurchasingManager`

- Stok kartlari
- Stok hareketleri
- Bekleyen stok talepleri
- Kritik dusuk stok raporlari
- Alim/maliyet raporlari

### `Employee`

- Kendi vardiyasi
- Kendi attendance kayitlari
- Kendi izin talepleri
- Kendi gorevleri
- Kendi performans gorunumu
- Kendi belgeleri
- Kendi servis/gorev atamalari

Not:
`Resepsiyonist` ayri bir sistem rolu olmamali. Bu, `Employee` rolundeki bir kullanicinin `EmployeeType` veya `Department` bilgisidir.

Resepsiyon employee type'i icin acik ekranlar:

- Misafir kaydi
- GuestStay
- Check-in / check-out
- Oda bazli misafir listesi
- Misafir servis taleplerine yardimci olma

### `Customer`

- Kendi rezervasyonu
- Kendi servis talepleri
- Kendi chat mesaji
- Kendi siparisleri
- Duyuru ve etkinlikler
- Puanlama

## Teknik Yetki Onerisi

Su an proje agirlikli olarak `[Authorize(Roles = "...")]` ile ilerliyor.
Bir sonraki asamada onerilen model:

1. Controller bazli genel rol korumasi
2. Handler icinde otel / departman / own-level veri kontrolu
3. Sonraki asamada policy-based authorization

Onerilen policy isimleri:

- `CanManageHotel`
- `CanViewManagementReports`
- `CanManageDepartment`
- `CanApproveLeaveRequest`
- `CanManageHr`
- `CanManageStock`
- `CanManageAttendance`
- `CanManagePerformance`
- `CanManageInternalAnnouncements`
- `CanManageEmployeeTasks`

## En Kritik Guvenlik Kurallari

Uygulamada mutlaka kontrol edilmesi gereken kurallar:

1. `DepartmentManager` sadece kendi departmanina ait personel, task, izin ve servis kayitlarini gormeli.
2. `Employee` sadece kendi kayitlarini ve kendine atanan isleri gormeli.
3. `Customer` sadece kendi `GuestStay`, `ServiceRequest`, `Order` ve `Rating` verilerine ulasabilmeli.
4. `Employee` rolundeki bir kullanici, resepsiyon employee type veya uygun policy olmadan check-in/check-out ekranlarini gormemeli.
5. `PurchasingManager` personel ozluk ve performans ekranlarina girmemeli.
6. `HRManager` finans ve misafir siparis detaylarini gorup degistirmemeli.

## Sonraki Uygulama Sirasi

Bu matrise gore teknik implementasyon sirasi:

1. `Roles` seed'ine `HRManager` ve `PurchasingManager` eklemek
2. `Register` ve kullanici olusturma akisinda rol atama mantigini sabit `RoleId = 1` yapisindan cikarmak
3. Tum controller'larda role bazli korumayi netlestirmek
4. Handler bazli `hotel/department/own` veri kisitlarini eklemek
5. Sonraki turda policy-based authorization katmanina gecmek
