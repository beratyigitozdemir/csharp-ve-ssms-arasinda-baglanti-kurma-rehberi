# Bağlantı Adımları

Bu klasör, C# ile SQL Server arasında bağlantı kurmak için izlenmesi gereken adımları içeren dosyaları barındırır. 

Her adım, bağlantı sürecinin bir aşamısını sade ve anlaşılır biçimde açıklar.

---
## Amaç

Bu rehberin amacı, bağlantı kurma sürecini parçalara ayırarak anlaşılır hale getirmek ve hem yeni başlayalara hem de deneyimli geliştiricilere referans sunmaktır.

## İçerik

| Dosya | Açıklama |
|-------|----------|
| `01-veritabani-ve-winforms-projesi-olusturma.md` | SSMS'de veritabanı oluşturma ve Visual Studio'da WinForms projesi hazırlama. |
| `02-nuget-paketi-kurulumu.md` | Gerekli NuGet paketinin projeye dahil edilmesi. |
| `03-kontrol-edilmesi-gereken-baglanti-ayarlari.md` | SQL Server ayarlarının bağlantı için uygun hale getirilmesi. |
| `04-connection-string.md` | Connection String yapısı ve yaygın türleri. |
| `05-sql-verisini-csharp-tarafinda-kullanma.md` | SQL verisinin C# tarafında nasıl kullanıldığı. |
| `06-olasi-hatalar-ve-kritik-noktalar.md` | Bağlantı sürecinde karşılaşılabilecek hatalar ve dikkat edilmesi gerekenler. |

## Rehberin Katkı Sağlayacağı Noktalar

**Bu rehberi tamamladığınızda aşağıdaki konular hakkında bilgi sahibi olmanız hedeflenir:**

- **Visual Studio'da basit bir Windows Forms arayüzü geliştirme.**
- **Bir NuGet paketinin projeye nasıl dahil edildiği.**
- **Bağlantı için gerekli olan yapılandırmaları kavrama.**
- **Connection String yapısını anlama ve özelleştirme.**
- **Windows Authentication ve SQL Server Authentication farklarını öğrenme.**
- `SqlConnection`, `SqlCommand` ve `SqlDataAdapter` **gibi sınıfların kullanımı.**
- **Veritabanından veri okuma, ekleme ve listeleme gibi işlemleri gerçekleştirme.**

Artık bu rehberin sonunda, bir C# uygulamasını SQL Server ile nasıl entegre edeciğinizi adım adım öğrenmiş olacak; bağlantı kurma, veri kaydetme, listeleme gibi temel işlemleri kendi projelerinizde uygulayabilecek düzeye geleceksiniz.

Rehbere başlamak için `Veritabanı ve WinForms Projesi oluşturma` adımına tıklayarak ilk bölüme geçebilirsiniz.

👇 İlk adım için tıklayın:  
🔗 [Veritabanı ve WinForms Projesi Oluşturma](./01-veritabani-ve-winforms-projesi-olusturma.md)