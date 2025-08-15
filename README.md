# 🚌 BİLETALL - Otobüs Bileti Satış Sistemi

BİLETALL, C# Windows Forms kullanılarak geliştirilmiş kapsamlı bir otobüs bileti satış ve yönetim sistemidir. Bu uygulama, müşterilerin otobüs bileti arama, satın alma ve yönetim işlemlerini kolayca gerçekleştirmelerini sağlar.

## 📋 İçindekiler

- [Özellikler](#özellikler)
- [Teknolojiler](#teknolojiler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Veritabanı Yapısı](#veritabanı-yapısı)
- [Proje Yapısı](#proje-yapısı)
- [Ekran Görüntüleri](#ekran-görüntüleri)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Lisans](#lisans)

## ✨ Özellikler

### 👤 Müşteri Özellikleri
- **Kullanıcı Kaydı ve Girişi**: TC kimlik numarası ile güvenli kayıt ve giriş sistemi
- **Sefer Arama**: Tarih, kalkış ve varış noktasına göre sefer arama
- **Fiyat Filtreleme**: Bütçeye uygun fiyat aralıklarında filtreleme
- **Koltuk Seçimi**: Görsel koltuk planı ile interaktif koltuk seçimi
- **Bilet Satın Alma**: Güvenli bilet satın alma işlemi
- **Biletlerim**: Satın alınan biletleri görüntüleme ve iptal etme

### 🔧 Admin Özellikleri
- **Müşteri Yönetimi**: Müşteri bilgilerini görüntüleme, düzenleme ve silme
- **Sefer Yönetimi**: Yeni sefer ekleme ve mevcut seferleri düzenleme
- **Bilet Yönetimi**: Tüm biletleri görüntüleme ve yönetme
- **Raporlama**: Satış raporları ve istatistikler

## 🛠️ Teknolojiler

- **Programlama Dili**: C# (.NET Framework 4.7.2)
- **Arayüz**: Windows Forms
- **Veritabanı**: Microsoft SQL Server
- **IDE**: Visual Studio
- **Dil**: Türkçe

## 📦 Kurulum

### Gereksinimler
- Windows 10/11
- .NET Framework 4.7.2 veya üzeri
- Microsoft SQL Server (Express veya üzeri)
- Visual Studio 2019/2022 (geliştirme için)

### Adım Adım Kurulum

1. **Projeyi İndirin**
   ```bash
   git clone https://github.com/kullaniciadi/BİLETALL.git
   cd BİLETALL
   ```

2. **Veritabanını Kurun**
   - SQL Server Management Studio'yu açın
   - `SQL/script.sql` dosyasını çalıştırın
   - Veritabanı bağlantı ayarlarını kontrol edin

3. **Uygulamayı Çalıştırın**
   - Visual Studio'da `BİLETALL.sln` dosyasını açın
   - F5 tuşuna basarak veya "Start Debugging" ile çalıştırın
   - Veya `bin/Debug/BİLETALL.exe` dosyasını çift tıklayın

## 🚀 Kullanım

### Müşteri Kullanımı
1. **Kayıt/Giriş**: Ana ekrandan kayıt olun veya giriş yapın
2. **Sefer Arama**: Kalkış, varış ve tarih bilgilerini girin
3. **Fiyat Filtreleme**: Bütçenize uygun fiyat aralığını seçin
4. **Koltuk Seçimi**: Boş koltuklardan birini seçin
5. **Bilet Satın Alma**: Bilet bilgilerini onaylayın ve satın alın

### Admin Kullanımı
1. **Admin Paneli**: Admin hesabı ile giriş yapın
2. **Müşteri Yönetimi**: Müşteri bilgilerini düzenleyin
3. **Sefer Yönetimi**: Yeni seferler ekleyin
4. **Raporlar**: Satış istatistiklerini görüntüleyin

## 🗄️ Veritabanı Yapısı

### Ana Tablolar
- **MUSTERİLER**: Müşteri bilgileri (TC, Ad, Soyad, Telefon, Parola)
- **SEFERLER**: Sefer bilgileri (Sefer No, Firma, Kalkış, Varış, Tarih, Saat, Fiyat)
- **BILETLER**: Bilet bilgileri (Bilet No, Sefer No, TC, Koltuk No)
- **SEFERKOLTUKBİLGİSİ**: Koltuk durumları (Sefer No, Koltuk No, Durum)

### Stored Procedures
- `biletlerim_sil`: Bilet iptal işlemi
- `FIYATFİLTRELE`: Fiyat bazlı filtreleme
- `Musteri_Ara`: Müşteri arama
- `Musteri_Guncelle`: Müşteri bilgi güncelleme
- `Musteri_Sil`: Müşteri silme

## 📁 Proje Yapısı

```
BİLETALL/
├── BİLETALL/
│   ├── Forms/
│   │   ├── frmgiriş.cs              # Ana giriş ekranı
│   │   ├── frmgirisyap.cs           # Giriş yapma ekranı
│   │   ├── frmkayitol.cs            # Kayıt olma ekranı
│   │   ├── frmmenu.cs               # Ana menü
│   │   ├── frmseferarama.cs         # Sefer arama ekranı
│   │   ├── frmFiyatFiltreleme.cs    # Fiyat filtreleme
│   │   ├── frmkoltuksecimi.cs       # Koltuk seçimi
│   │   ├── frmbiletlerim.cs         # Biletlerim ekranı
│   │   └── frmadminpanel.cs         # Admin paneli
│   ├── Data/
│   │   ├── BiletAlDataSet.xsd       # Veritabanı şeması
│   │   └── BiletAlDataSet.Designer.cs
│   ├── Resources/                   # Görsel kaynaklar
│   ├── Properties/                  # Proje özellikleri
│   └── Program.cs                   # Ana program dosyası
├── SQL/
│   └── script.sql                   # Veritabanı kurulum scripti
└── BİLETALL.sln                     # Visual Studio solution
```

## 📸 Ekran Görüntüleri

Proje içerisinde `Resources/` klasöründe uygulama ekran görüntüleri bulunmaktadır.

## 🤝 Katkıda Bulunma

1. Bu repository'yi fork edin
2. Yeni bir branch oluşturun (`git checkout -b feature/yeni-ozellik`)
3. Değişikliklerinizi commit edin (`git commit -am 'Yeni özellik eklendi'`)
4. Branch'inizi push edin (`git push origin feature/yeni-ozellik`)
5. Pull Request oluşturun

## 📝 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için `LICENSE` dosyasına bakın.

## 📞 İletişim

- **Geliştirici**: [Adınız]
- **E-posta**: [e-posta adresiniz]
- **GitHub**: [GitHub profiliniz]

## 🙏 Teşekkürler

Bu projeyi geliştirirken kullanılan tüm açık kaynak kütüphanelere ve topluluğa teşekkürler.

---

⭐ Bu projeyi beğendiyseniz yıldız vermeyi unutmayın!
