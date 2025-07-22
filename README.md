# C# ile SSMS Arasında Bağlantı Kurma - Rehber

Bu rehber, C# uygulamaları ile SQL Server Management Studio (SSMS) arasında bağlantı kurma sürecini kapsamlı bir biçimde ele alır. Bağlantı için izlenmesi gereken adımları, **connection string** gibi kritik noktaları birlikte açıklayarak, güvenli ve kararlı bir bağlantının nasıl sağlanacağını göstermeyi hedefler.

---
## Rehberin Amacı

C# ile SQL Server arasında bağlantı kurma sürecine dair temel kavramları bilmeyen kullanıcılar için açıklayıcı bilgiler sunmak; konuya aşina olan geliştiriciler için hatırlatıcı ve referans niteliğinde bir kaynak sağlamak amaç edinmiştir.

> İki farklı kullanıcı kitlesine hitap etmektedir:

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

## Proje Yapısı

```

📁 csharp-ve-ssms-arasinda-baglanti-kurma-rehberi/
├── 📁 baglanti-rehberi/
│   ├───
│   │   ├──  📖 01-veritabani-ve-winforms-projesi-olusturma.md
│   │   ├──  📖 02-nuget-paketi-kurulumu.md
│   │   ├──  📖 03-baglanti-ayarlari.md
│   │   ├──  📖 04-connection-string.md
│   │   └──  📖 05-sql-verisini-csharp-tarafinda-kullanma.md
│   └──────	 📖 06-olasi-hatalar-ve-kritik-noktalar.md   
│
├── 📁 sqlserverconnection
│   ├─── 
│			├──📁 sqlserverconnection  			
│	  		└──📝 README.md
│	
├── © LICENSE
└──📝 README.md

```
 
## İçerik

Aşağıdaki içerik tablosu, bu rehberde ele alınan konulara hızlı erişim sağlayacak şekilde yapılandırılmıştır. Başlıklara tıklayarak doğrudan ilgili bölümlere geçiş yapabilirsiniz. 

- [Veritabanı Oluşturma](baglanti-rehberi/01-veritabani-ve-winforms-projesi-olusturma.md)
- [WinForms Projesi Oluşturma](https://github.com/beratyigitozdemir/csharp-ve-ssms-arasinda-baglanti-kurma-rehberi/blob/main/baglanti-rehberi/01-veritabani-ve-winforms-projesi-olusturma.md#visual-studioda-winforms-projesi-olu%C5%9Fturma)
- [NuGet Paketi Kurma](baglanti-rehberi/02-nuget-paketi-kurulumu.md)
- [Bağlantı Ayarları](baglanti-rehberi/03-baglanti-ayarlari.md)
- [Connection String](baglanti-rehberi/04-connection-string.md)
- [SQL Verisini C#'ta Kullanma](baglanti-rehberi/05-sql-verisini-csharp-tarafinda-kullanma.md)
- [Olası Hatalar ve Kritik Noktalar](baglanti-rehberi/06-olasi-hatalar-ve-kritik-noktalar.md)

---

## Lisans

Bu repodaki içerikler [MIT Lisansı](LICENSE) ile korunmaktadır.

© 2025 Berat Yiğit Özdemir
