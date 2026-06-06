# Worigo Role Based Screen Brief

Bu dokuman, web panel ve mobil uygulama ekran tasarimlari icin rol bazli ekran kapsamlarini netlestirir.

## Urun Ayrimi

- Musteri tarafi mobil uygulamadir.
- Hotel yonetimi, resepsiyon, personel ve finans tarafi web paneldir.
- Worigo Finance basit on muhasebe moduludur.
- Tam ERP, e-fatura, resmi muhasebe ve bordro bu kapsama dahil degildir.

## 1. SystemAdmin

Platformun en ust yoneticisidir. Tum sirketleri, otelleri ve sistem ayarlarini yonetir.

### Ekranlar

- Dashboard
  - Toplam sirket, otel, kullanici ve aktif otel sayisini gorur.
  - Sistem geneli operasyon ozetini gorur.
- Sirket Yonetimi
  - Sirket listesi gorur.
  - Yeni sirket ekler.
  - Sirket bilgilerini duzenler.
  - Sirket aktif/pasif yapar.
- Otel Yonetimi
  - Tum otelleri listeler.
  - Yeni otel acar.
  - Otel bilgilerini duzenler.
  - Otel aktif/pasif yapar.
- Kullanici ve Rol Yonetimi
  - Kullanici listesi gorur.
  - Kullaniciya rol atar.
  - Kullanici aktif/pasif yapar.
- Sistem Ayarlari
  - Genel parametreleri yonetir.
  - Dil/ceviri ayarlarini yonetir.
  - Servis sablonlarini yonetir.
- Log ve Teknik Izleme
  - Sistem loglarini gorur.
  - Hata kayitlarini inceler.

## 2. HotelAdmin

Tek bir otelin tum operasyon, finans ve yonetim ekranlarina sahiptir.

### Ekranlar

- Otel Dashboard
  - Gunluk talepler, siparisler, doluluk ve personel durumunu gorur.
  - Departman bazli operasyon ozetini takip eder.
- Otel Bilgileri
  - Otel adi, adres, telefon, e-posta ve temel ayarlari duzenler.
- Departman Yonetimi
  - Departman ekler, duzenler, aktif/pasif yapar.
  - Departman yoneticisi atar.
- Personel Yonetimi
  - Personel listesi gorur.
  - Personel ekler ve duzenler.
  - Departman, gorev tipi, vardiya ve musaitlik durumunu yonetir.
- Employee Type / Gorev Tipleri
  - Resepsiyonist, teknik servis, housekeeping gibi gorev tiplerini yonetir.
- Oda Yonetimi
  - Oda listesi, oda tipi, kat, durum ve doluluk bilgisini yonetir.
- Misafir / Konaklama Yonetimi
  - Aktif konaklamalari gorur.
  - Check-in/check-out kayitlarini takip eder.
- Servis Kataloglari
  - Misafire gosterilecek servisleri yonetir.
  - Servis adi, aciklama, gorsel, fiyat, sure ve bot acilis mesajini girer.
  - Servisin hangi departmana dusecegini belirler.
- Servis Atama Kurallari
  - Servis, departman, employee type, SLA ve oncelik iliskisini yonetir.
- Misafir Talepleri
  - Tum otel taleplerini gorur.
  - Talep durumunu ve atamalarini takip eder.
- Siparisler
  - Yemek, minibar ve ucretli servis siparislerini gorur.
  - Odeme durumunu takip eder.
- Stok Yonetimi
  - Stok kartlari, stok hareketleri, stok talepleri ve kritik stoklari yonetir.
- IK / Izin / Vardiya
  - Izin talepleri, vardiyalar, mesai kayitlari ve personel evraklarini yonetir.
- Finance Dashboard
  - Gunluk gelir, gider, net kasa ve bekleyen tahsilatlari gorur.
- Gelirler
  - Siparis ve servis gelirlerini listeler.
  - Odeme durumlarini takip eder.
- Misafir Hesabi
  - GuestStay bazli hesap/folio gorur.
  - Check-out hesap ozetini kontrol eder.
- Kasa
  - Kasa hareketlerini ve kasa kapanisini takip eder.
- Giderler
  - Gider ekler, duzenler ve odeme durumunu takip eder.
- Tedarikciler
  - Tedarikci kaydi acar, duzenler ve borc ozetini gorur.
- Stok Maliyet
  - Stok giris maliyeti ve departman tuketim maliyetini gorur.
- Finans Raporlari
  - Gelir-gider, kasa, servis geliri ve tedarikci borc raporlarini gorur.

## 3. Management

Otel yonetim ekibidir. Izleme, analiz ve raporlama odaklidir.

### Ekranlar

- Yonetim Dashboard
  - Gunluk operasyon ozeti, acik talepler ve geciken isleri gorur.
- Finans Raporlari
  - Gelir-gider ve operasyonel karlilik raporlarini gorur.
- Finance Dashboard
  - Sadece okuma yetkisiyle finans ozetlerini gorur.
- Kasa Ozeti
  - Gunluk kasa durumunu okur.
- Tedarikci Borc Ozeti
  - Bekleyen odemeleri okur.
- Operasyon Raporlari
  - Talep sayilari, ortalama cozum suresi ve en cok talep edilen servisleri gorur.
- Departman Performansi
  - Departman bazli is yuku ve SLA basarisini gorur.
- Personel Performansi
  - Personel bazli tamamlanan isleri ve misafir puanlarini gorur.
- Attendance / Mesai Ozeti
  - Personel devam durumu ve fazla mesai ozetini gorur.

## 4. DepartmentManager

Kendi departmaninin personel, talep, gorev, stok ve maliyet ozetlerini yonetir.

### Ekranlar

- Departman Dashboard
  - Kendi departmanina gelen isleri ve geciken talepleri gorur.
- Departman Personeli
  - Kendi departmanindaki personelleri ve musaitlik durumunu gorur.
- Departman Talepleri
  - Kendi departmanina gelen servis taleplerini gorur.
  - Talebi personele atar ve durumunu takip eder.
- Gorev Yonetimi
  - Personeline gorev olusturur, atar ve takip eder.
- Stok Talepleri
  - Departman stok ihtiyaci olusturur ve takip eder.
- Departman Maliyet Ozeti
  - Kendi departmaninin stok tuketimi ve gider ozetini gorur.
- Departman Giderleri
  - Kendi departmanina yazilan giderleri okur.
- Izin Onaylari
  - Kendi departman personelinin izin taleplerini onaylar veya reddeder.
- Departman Raporlari
  - Kendi departmaninin operasyon ve maliyet raporlarini gorur.

## 5. HRManager

Insan kaynaklari, izin, belge, performans ve attendance sureclerini yonetir.

### Ekranlar

- IK Dashboard
  - Aktif personel, bekleyen izinler, eksik evraklar ve mesai ozetini gorur.
- Personel Ozluk
  - Personel detaylarini ve is gecmisini gorur.
- Personel Belgeleri
  - Evraklari takip eder, onaylar ve eksik belge uyarilarini gorur.
- Izin Yonetimi
  - Tum izin taleplerini gorur.
  - IK onayi gereken talepleri onaylar veya reddeder.
- Attendance / Mesai
  - Personel giris-cikis, devamsizlik ve fazla mesai kayitlarini gorur.
- Performans Degerlendirme
  - Performans kaydi olusturur ve gecmisi takip eder.
- IK Duyurulari
  - Personel duyurusu olusturur ve yayina alir.

## 6. PurchasingManager

Satin alma, stok, tedarikci ve maliyet takibinden sorumludur.

### Ekranlar

- Satin Alma Dashboard
  - Kritik stoklar, bekleyen stok talepleri ve son stok hareketlerini gorur.
- Stok Kartlari
  - Stok karti olusturur ve minimum stok seviyesini belirler.
- Stok Hareketleri
  - Stok giris/cikis hareketlerini gorur ve kaydeder.
- Stok Talepleri
  - Departmanlardan gelen stok taleplerini onaylar veya reddeder.
- Giderler
  - Satin alma ve stok kaynakli giderleri girer.
- Tedarikciler
  - Tedarikci listesi ve detaylarini yonetir.
- Tedarikci Borc Takibi
  - Odenecek tedarikci tutarlarini takip eder.
- Stok Maliyet
  - Stok giris fiyatlarini ve maliyet raporlarini gorur.
- Kritik Stok Raporu
  - Minimum seviyenin altindaki urunleri gorur.

## 7. Employee

Kendi gorevlerini, vardiyasini, izinlerini ve kendisine atanan talepleri gorur.

### Ekranlar

- Personel Ana Sayfa
  - Bugunku gorevleri, atanmis servis talepleri ve vardiya bilgisini gorur.
- Atanmis Talepler
  - Kendisine atanan servis taleplerini gorur.
  - Talep durumunu acik, islemde veya tamamlandi olarak gunceller.
- Gorevlerim
  - Kendisine atanan ic gorevleri takip eder.
- Vardiyam
  - Bugunku ve haftalik vardiyasini gorur.
- Attendance / Mesai
  - Kendi giris-cikis ve mesai gecmisini gorur.
- Izinlerim
  - Izin talebi olusturur ve durumunu takip eder.
- Belgelerim
  - Kendi evraklarini gorur ve gerekirse belge yukler.
- Performansim
  - Kendi performans degerlendirmelerini gorur.
- Duyurular
  - Personele acik duyurulari gorur.

## 8. Reception

Teknik olarak ayri rol olmak zorunda degildir. `Employee` rolundeki bir kullanicinin employee type veya departmani resepsiyon olur.

### Ekranlar

- Resepsiyon Dashboard
  - Bugunku check-in, check-out, aktif konaklama ve acik misafir taleplerini gorur.
- Misafir Listesi
  - Aktif misafirleri, oda numarasini ve konaklama tarihlerini gorur.
- Check-in
  - Konaklama kaydi acar, misafir bilgisi girer ve oda atar.
- Check-out
  - Cikis islemi yapar, acik hesaplari kontrol eder.
- Oda Durumu
  - Bos, dolu, bakimda ve temizlikte odalari gorur.
- Misafir Talepleri
  - Misafir taleplerini gorur ve gerekirse talep olusturur.
- Resepsiyon Chat
  - Misafir serbest mesajlarini gorur ve cevap yazar.
- Misafir Hesabi / Folio
  - Misafirin oda hesabini gorur.
- Check-out Hesap Ozeti
  - Cikis oncesi acik ucretleri kontrol eder.
- Yerinde Tahsilat
  - Resepsiyonda alinan odemeyi kaydeder.
- Odaya Yansitilan Ucretler
  - Siparis ve servis ucretlerini misafir hesabinda gorur.

## 9. Customer / Misafir Mobil Uygulama

Musteri sadece mobil uygulamayi kullanir. Kendi konaklamasina ait verilere erisir.

### Ekranlar

- Splash / Giris
  - Otel karsilama ve QR ile giris yapar.
- Ana Sayfa
  - Otel, oda bilgisi, hizli aksiyonlar ve aktif talepleri gorur.
- Hizmetler
  - Otelin sundugu servis kategorilerini gorur.
- Chat Tabanli Talep Ekrani
  - Bot acilis mesajini gorur.
  - Secenek, urun karti veya form ile talep olusturur.
- Yemek / Menu Siparisi
  - Urun secer, sepete ekler ve siparis olusturur.
- Oda Hizmetleri Talebi
  - Havlu, terlik, sampuan, yastik gibi talepler olusturur.
- Teknik Servis Talebi
  - Sorun konusu, aciklama ve aciliyet secerek talep olusturur.
- Bilgilendirme
  - Wi-Fi, kahvalti, havuz, etkinlik, kurallar ve ulasim bilgilerini gorur.
- Resepsiyon Chat
  - Resepsiyona serbest mesaj yazar.
- Taleplerim
  - Aktif ve gecmis taleplerini takip eder.
- Siparislerim
  - Kendi siparislerini ve odeme durumlarini gorur.
- Harcama Ozeti
  - Kendi konaklamasina ait harcamalari gorur.
- Odaya Yansitilanlar
  - Oda hesabina yazilan kalemleri gorur.
- Bildirimler
  - Talep, siparis ve resepsiyon mesaj bildirimlerini gorur.
- Profil
  - Misafir, oda, konaklama ve dil bilgilerini gorur.
- Puanlama
  - Tamamlanan servis talebini puanlar ve yorum yazar.

## 10. Ortak Talep Durumlari

- Olusturuldu
- Atandi
- Islemde
- Musteri yaniti bekleniyor
- Tamamlandi
- Iptal edildi

## 11. Finance Durumlari

- Bekleyen tahsilat
- Odaya yansitildi
- Odendi
- Online odeme bekliyor
- Iptal edildi
- Iade edildi
- Gider odendi
- Gider bekliyor
- Kasa kapandi
