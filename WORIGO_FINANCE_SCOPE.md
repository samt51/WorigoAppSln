# Worigo Finance - On Muhasebe Modulu

Bu dokuman, Worigo icine eklenecek basit on muhasebe modulunun kapsamını, mevcut mimaride karsilanan kisimlari ve eklenmesi gereken tablolari netlestirmek icin hazirlandi.

Worigo Finance tam ERP veya resmi muhasebe sistemi degildir. Amaci otel operasyonundan dogan gelir, gider, kasa, misafir hesabi ve tedarikci borc takibini sade sekilde yonetmektir.

## Kapsam Karari

- Worigo icinde basit on muhasebe modulu olacak.
- Tam ERP, e-fatura, genel muhasebe, hesap plani, bordro, banka entegrasyonu sonraki proje veya entegrasyon konusu olacak.
- Ilk hedef otelin gunluk gelir-gider, kasa, misafir hesabi ve basit tedarikci takibini yapabilmesidir.

## Mimari Kapsam Tablosu

| Finance Ozelligi | Mevcut Mimari Karsiliyor mu? | Mevcut Tablo/Model | Eksik veya Yapilacak |
|---|---:|---|---|
| Siparis gelirleri | Evet | `Order`, `OrderItem` | Listeleme ve finans rapor endpointleri gerekir |
| Servis gelirleri | Kismen | `Order`, `Charge`, `HotelServicePolicy`, `ServiceRequest` | Servis bazli gelir raporu gerekir |
| Odaya yansitilan ucretler | Evet | `Charge`, `GuestStay` | Misafir hesabi/folio ekrani gerekir |
| Online odeme denemeleri | Evet | `PaymentTransaction` | Odeme saglayici entegrasyonu sonra eklenir |
| Yerinde odeme kaydi | Kismen | `Charge`, `PaymentTransaction` | Manuel tahsilat ekrani ve odeme tipi netlestirilmeli |
| Check-out hesap ozeti | Kismen | `GuestStay`, `Charge`, `Order` | GuestStay bazli hesap ozeti endpointi gerekir |
| Kasa hareketleri | Hayir | Yok | `CashTransaction` tablosu onerilir |
| Gunluk kasa kapanisi | Hayir | Yok | `CashSession` veya `CashClosure` tablosu onerilir |
| Gider takibi | Hayir | Yok | `Expense`, `ExpenseCategory` tablolari onerilir |
| Tedarikci listesi | Hayir | Yok | `Supplier` tablosu onerilir |
| Tedarikci basit cari | Hayir | Yok | `SupplierAccountTransaction` veya giderden turetilen cari rapor onerilir |
| Stok maliyeti | Evet | `StockItem`, `StockMovement` | Finans raporlarina baglanmali |
| Departman bazli tuketim maliyeti | Kismen | `StockMovement.DepartmentId` | Departman maliyet raporu gerekir |
| Kritik stok finans etkisi | Kismen | `StockItem`, `StockMovement` | Kritik stok maliyet raporu gerekir |
| Gelir-gider dashboard | Kismen | `Order`, `Charge`, `StockMovement` | Gider ve kasa tablolari eklendikten sonra tamamlanir |
| Tedarikci borc raporu | Hayir | Yok | `Supplier` + `Expense`/cari kayit gerekir |

## Onerilen Yeni Tablolar

### `ExpenseCategory`

Giderleri siniflandirmak icin kullanilir.

- `Id`
- `HotelId`
- `Name`
- `Description`
- `IsActive`

Ornek kategoriler:

- Mutfak
- Temizlik
- Teknik bakim
- Personel
- Satin alma
- Enerji
- Diger

### `Supplier`

Tedarikci veya firma bilgisini tutar.

- `Id`
- `HotelId`
- `Name`
- `TaxNumber`
- `TaxOffice`
- `PhoneNumber`
- `Email`
- `Address`
- `ContactPerson`
- `IsActive`

### `Expense`

Otel gider kaydini tutar.

- `Id`
- `HotelId`
- `ExpenseCategoryId`
- `SupplierId`
- `DepartmentId`
- `Title`
- `Description`
- `InvoiceNo`
- `ExpenseDate`
- `DueDate`
- `Amount`
- `TaxAmount`
- `TotalAmount`
- `CurrencyCode`
- `PaymentStatus`
- `PaymentMethod`
- `PaidAt`
- `CreatedByEmployeeId`

### `CashTransaction`

Kasa giris/cikis hareketini tutar.

- `Id`
- `HotelId`
- `GuestStayId`
- `ChargeId`
- `ExpenseId`
- `EmployeeId`
- `TransactionType`
- `PaymentMethod`
- `Amount`
- `CurrencyCode`
- `Description`
- `OccurredAt`

Ornek hareket tipleri:

- Gelir tahsilati
- Gider odemesi
- Kasa duzeltme
- Iade

### `CashClosure`

Gunluk veya vardiya bazli kasa kapanisini tutar.

- `Id`
- `HotelId`
- `EmployeeId`
- `OpeningAmount`
- `ExpectedCashAmount`
- `CountedCashAmount`
- `DifferenceAmount`
- `OpenedAt`
- `ClosedAt`
- `Note`

## Finance Ekranlari

### Finance Dashboard

- Bugunku toplam gelir
- Bugunku toplam gider
- Net kasa
- Bekleyen tahsilatlar
- Odaya yansitilmis acik tutarlar
- Bekleyen tedarikci odemeleri
- Kritik stok maliyet uyarilari

### Gelirler

- Siparis gelirlerini listeler.
- Servis gelirlerini listeler.
- Odaya yansitilan ucretleri gosterir.
- Odeme durumuna gore filtreler.
- Tarih, servis tipi, departman ve odeme tipi filtreleri olur.

### Misafir Hesabi

- GuestStay bazli hesap/folio gosterir.
- Siparisleri, servis ucretlerini ve odemeleri listeler.
- Odenmis, bekleyen, iptal edilen kalemleri ayirir.
- Check-out sirasinda hesap ozeti verir.

### Kasa

- Gunluk kasa hareketlerini gosterir.
- Nakit, kart, online odeme ayrimi yapar.
- Manuel tahsilat kaydi alir.
- Gider odemesi kaydi alir.
- Kasa kapanisi yapar.

### Giderler

- Gider listesi gosterir.
- Gider ekler.
- Gider kategorisi, tedarikci, departman, tarih, tutar, odeme durumu girilir.
- Fatura/fis numarasi tutulur.
- Odenmis ve odenecek giderler ayrilir.

### Tedarikciler

- Tedarikci listesi gosterir.
- Tedarikci ekler ve duzenler.
- Tedarikci detayinda gider gecmisi gosterir.
- Odenecek toplam tutar ve son odeme tarihleri gosterilir.

### Stok Maliyet

- Stok giris maliyetlerini gosterir.
- Departman bazli stok tuketim maliyetini gosterir.
- Kritik stoklarin yaklasik satin alma ihtiyacini gosterir.

### Finans Raporlari

- Gunluk gelir raporu
- Gunluk gider raporu
- Aylik gelir-gider raporu
- Net kasa raporu
- Servis bazli gelir raporu
- Departman bazli maliyet raporu
- Tedarikci borc raporu

## Rol Bazli Finance Yetkileri

| Ekran | HotelAdmin | Management | PurchasingManager | Reception | DepartmentManager | Employee | Customer |
|---|---|---|---|---|---|---|---|
| Finance Dashboard | Tam | Okuma | Kismi | Yok | Yok | Yok | Yok |
| Gelirler | Tam | Okuma | Yok | Kismi | Yok | Yok | Yok |
| Misafir Hesabi | Tam | Okuma | Yok | Tam | Yok | Yok | Kendi hesabi |
| Kasa | Tam | Okuma | Yok | Kismi | Yok | Yok | Yok |
| Giderler | Tam | Okuma | Tam/Kismi | Yok | Kendi departmani okuma | Yok | Yok |
| Tedarikciler | Tam | Okuma | Tam | Yok | Yok | Yok | Yok |
| Stok Maliyet | Tam | Okuma | Tam | Yok | Kendi departmani okuma | Yok | Yok |
| Finans Raporlari | Tam | Okuma | Kismi | Yok | Kendi departmani okuma | Yok | Yok |

## Ilk Uygulama Sirasi

1. Finance dokumanindaki yeni entityleri ekle.
2. `ExpenseCategory`, `Supplier`, `Expense`, `CashTransaction`, `CashClosure` tablolarini olustur.
3. Mevcut `Charge`, `Order`, `PaymentTransaction` uzerinden gelir listeleme endpointleri yaz.
4. GuestStay bazli misafir hesabi endpointi yaz.
5. Gider ve tedarikci CRUD endpointleri yaz.
6. Kasa hareketi ve kasa kapanisi endpointleri yaz.
7. Dashboard ve rapor querylerini ekle.
8. Rol bazli ekran ve endpoint yetkilerini uygula.

## ERP Disinda Birakilanlar

- Genel muhasebe fisleri
- Tek duzen hesap plani
- E-fatura/e-arsiv
- Bordro
- Banka entegrasyonu
- Cek/senet
- Vergi beyannamesi
- Donem kapanisi
- Resmi muhasebe defterleri

Bu maddeler sonraki ERP projesinde veya harici muhasebe entegrasyonunda ele alinmalidir.
