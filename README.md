# Formula 1 Veritabanı Projesi

Bu proje, Formula 1 sporu ile ilgili verileri içeren bir veritabanı ödevidir. Proje, F1 takımları, pilotlar, yarışlar ve sonuçlar gibi bilgileri düzenli ve erişilebilir bir şekilde yönetmeyi amaçlamaktadır.

## Proje Yapısı

```
VeriTabanı/
├── f1database.sql    # PostgreSQL veritabanı şeması ve verileri
├── VTYSUI/           # Windows Forms masaüstü uygulaması
│   ├── VTYSUI.sln    # Visual Studio solution dosyası
│   └── VTYSUI/       # C# proje dosyaları
├── README.md
└── .gitignore
```

## Gereksinimler

- **PostgreSQL** (14 veya üzeri önerilir)
- **Visual Studio 2022** veya .NET Framework 4.7.2 destekleyen bir IDE
- **.NET Framework 4.7.2**

## Kurulum

### 1. Veritabanını Oluşturma

PostgreSQL kurulu olduğundan emin olun, ardından:

```bash
# PostgreSQL'e bağlanıp veritabanı oluşturun
psql -U postgres -c "CREATE DATABASE f1database;"

# SQL dosyasını çalıştırın
psql -U postgres -d f1database -f f1database.sql
```

Windows'ta pgAdmin kullanıyorsanız: **Query Tool** açın, `f1database.sql` dosyasının içeriğini yapıştırıp çalıştırın.

### 2. Uygulamayı Derleme

1. Projeyi Visual Studio ile açın (`VTYSUI/VTYSUI.sln`)
2. **Build** → **Restore NuGet Packages** ile bağımlılıkları indirin
3. **Build** → **Build Solution** (Ctrl+Shift+B)

### 3. Bağlantı Ayarları

Varsayılan bağlantı bilgileri `Form1.cs` içinde tanımlıdır:

- **Host:** localhost
- **Port:** 5432
- **Database:** f1database
- **User:** postgres
- **Password:** *(kendi şifrenizi girin)*

> ⚠️ **Güvenlik:** Üretim ortamında şifreleri kod içinde tutmayın. `App.config` veya ortam değişkenleri kullanın.

## Kullanım

Uygulama çalıştırıldığında:

- **Takım Üyeleri, Araba, Şehir, Sponsor, Pilot** tablolarını görüntüleyebilirsiniz
- Sponsor tablosunda **Ekle**, **Güncelle** ve **Sil** işlemleri yapılabilir

## Veritabanı Tabloları

- `TEAM_MEMBER` — Takım üyeleri
- `CAR` — Araç bilgileri
- `CITY` — Şehir bilgileri
- `SPONSOR` — Sponsor bilgileri
- `DRIVER` — Pilot bilgileri

## Lisans

Bu proje eğitim amaçlı hazırlanmıştır.
