# C# ile SSMS Arasında Bağlantı Kurma - Rehber

Bu rehber, C# ile SQL Server Management Studio (SSMS) arasında bağlantı kurma sürecini detaylı bir şekilde inceler. Bağlantı cümlesi (connection strings), SQL Server yapılandırma ayarları, kimlik doğrulama yöntemleri, şifreleme ve güvenlik önlemleri gibi kritik bileşenlere dair teknik bilgiler sunar.

---
## Rehberin Amacı

C# ile SQL Server arasında bağlantı kurma sürecine dair temel kavramları bilmeyen kullanıcılar için açıklayıcı bilgiler sunmak; konuya aşina olan geliştiriciler için hatırlatıcı ve referans niteliğinde bir kaynak sağlamak amaç edinmiştir.
**İki farklı kullanıcı kitlesine** hitap etmeyi amaçlar:

### 1. Temel Bilgiye İhtiyaç Duyanlar

**Hedef Kitle:** Veritabanı bağlantısı kurma sürecine yeni başlayan ya da C# ile SQL Server arasında bağlantı kurma konusunda deneyimi olmayan kişiler.

- C# uygulamaları ile SQL Server arasında nasıl bağlantı kurulacağını adım adım açıklamak.
- **Connection String** (bağlantı dizesi) yapısını tanıtıp öğretmek.
- SQL Server yapılandırma ve temel ayarlarını sade bir dille anlatmak.

### 2. Deneyimli Geliştiriciler

**Hedef Kitle:** Daha önce veritabanı bağlantısı kurmuş ancak süreçteki detayları gözden geçirmek veya yeniden yapılandırmak isteyen geliştiriciler.

- **Bağlantı güvenliği**, **şifreleme seçenekleri** ve **bağlantı protokollerine** dair önemli detayları özetlemek.
- **Farklı bağlantı türleri** ve **kimlik doğrulama yöntemlerine** (Windows Authentication ve SQL Authentication gibi) hızlı bir bakış sunmak.
- Kısayol niteliğinde kullanılabilecek, teknik referans bölümleri oluşturmak.

---
 
## İçerik

- [Veritabanı Oluşturma](docs/01-veritabani-ve-winforms-projesi-olusturma.md)
- [WinForms Projesi Oluşturma](docs/01-veritabani-ve-winforms-projesi-olusturma.md)
- [NuGet Paketi Kurma](docs/02-baglanti-ayarlari-ve-nuget-paketi-kurma.md)
- [Bağlantı Ayarları](docs/02-baglanti-ayarlari-ve-nuget-paketi-kurma.md)
- [Connection String](docs/03-connection-string.md)
- [Olası Hatalar ve Kritik Noktalar](docs/04-olasi-hatalar-ve-kritik-noktalar.md)
- [SQL Verisini C#'ta Kullanma](docs/05-sql-verisini-kullanma-ornegi.md)
---

## Lisans

Bu repodaki içerikler [MIT Lisansı](LICENSE) ile korunmaktadır.
---
