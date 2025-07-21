# SQL Server Bağlantısı için Temel Form Uygulaması

Bu proje, **C# programlama dili** kullanılarak geliştirilen basit bir **Windows Forms** uygulamasıdır. Hazırlanan bu uygulamada, kullanıcıdan veri almak, alınan verileri veritabanına kaydetmek ve kaydedilen verileri listelemek hedeflenmiştir.

---

## Uygulamanın Amacı

C# ile SQL Server arasında bağlantı kurmayı öğrenmek isteyen geliştiriciler için temel bir örnek sunar.

**Aşağıdaki konuların pratiğe dökülmesini sağlar:**

- Windows Forms üzerinde `TextBox`, `Button` ve `DataGridView` gibi bileşenlerle arayüz tasarımı ve kullanımı.
- NuGet üzerinden `Microsoft.Data.SqlClient` paketinin projeye dahil edilmesi.
- SQL Server ile güvenli bağlantı kurulması → **Windows Authetication**
- `SqlConnection`, `SqlCommand` ve `SqlDataAdapter` gibi sınıfların kullanımı.

## İçerik Özeti

**Uygulama temel olarak şu adımlari içerir:**

1. Form bileşenleri üzerinden kullanıcıdan ad, soyad bilgisi alma.
2. `Kaydet` butonuyla SQL Server'a alınan verileri ekleme.
3. `KisileriListele()` metodu ile veritabanındaki tüm kayıtları listeleme.
5. DataGridView ile verilerin kullanıcıya listelenmesi.

## Dikkat Edilmesi Gerekenler

> Proje içindeki `connectionString` yapısını SQL Server ortamınıza göer **düzenlenmelidir**.
> Önceki bölümlerde hazırladığımız veritabanını kullanacağınız için sadece `Server` adını değiştirmeniz yeterli olacaktır.

## Uygulamanın Tüm Mantığını İçeren Kod

Kullanıcıdan alınan verilerin veritabanına kaydedilmesi, kayıtların listelenmesi ve SQL bağlantısının yönetilmesi gibi işlemler, bu dosyada tanımlanmıştır.

🔗 [Tıklayarak Koda Ulaşabilirsiniz](./sqlserverconnection/Form1.cs)

---
