# Olası Hatalar ve Kritik Noktalar

Bağlantı süreci ve veritabanı işlemleri sırasında bazı teknik sorunlarla karşılaşmak mümkündür.

Bu bölüm, geliştirdiğimiz **WinForms** uygulamasının çalışmasını engelleyebilecek hataları ve dikkat edilmesi gereken kritik noktaları incelemeyi amaçlamıştır.

**Böylece uygulamanın sorunsuz çalışmasını sağlamak ve hata ayıklama sürecinde zaman kazanmak mümkün olacaktır.**

---

## Olası Hatalar

Hazırladığımız Windows Forms uygulamasını çalıştırma sürecinde, **belirli yapılandırma eksiklikleri** veya **çevresel etkenler nedeniyle** çeşitli hatalarla karşılaşılabilir.

**En sık karşılaşabileceğiniz 2 hata ele alınacak, her birine yönelik olası nedenler ve çözüm yolları açıklanacaktır.**

### 1. Sunucu Bulunamadı veya Erişilemiyor

![image](https://github.com/user-attachments/assets/a443b833-ef57-4ff2-83d6-3a4894f0e94a)

> Hatanın Kaynağı:

Bu hata, SQL Server'a bağlantı kurulamaması durumunda oluşur. Hata kodu `Error:40`, SQL Server'a bağlanma girişiminin başarısız olduğu gösterilir.

| **Neden**                 | **Açıklama**                             | **Çözüm**                                                              |
|---------------------------|------------------------------------------|------------------------------------------------------------------------|
| SQL Server çalışmıyor     | Sunucu kapalıysa bağlantı kurulamaz.     | `services.msc` → **SQL Server (MSSQLSERVER)** servisini başlatın.     |
| Connection string hatalı  | Tanım eksik veya yanlış olabilir.        | Yapının doğru tanımlandığından emin olun.                             |
| TCP/IP devre dışı         | Ağ bağlantısı kurulamaz.                 | `SQL Server Configuration Manager` → **TCP/IP**’yi etkinleştirin.     |

> Önerilen Adımlar:

1. **SQL Server servisi açık mı kontrol edin.**
2. **Connection String yapısında girdiğin bilgilerin doğru olduğundan emin ol ve eksiklik var mı kontrol edin.**
3. **Yapılması ve kontrol edilmesi gereken bağlantı ayarları doğru yapılandırıldı mı?** → `TCP/IP Protokolü` **açık mı emin olun**


### 2. NuGet Paketi Eksik veya Referans Hatası

![image](https://github.com/user-attachments/assets/e6975178-8f2d-4741-8988-1bd295ceb562)

Bu görseldeki hata mesajı, C# derleyicisinin `SqlConnection` türünü tanıyamadığını gösteriyor.

> Hatanın Kaynağı:

Gerekli namespace eklenmemişse ya da ilgili NuGet paketi projeye yüklenmemişse bu hata meydana gelir.

1. `Microsoft.Data.SqlClient` **NuGet paketinin yüklendiğinden emin olun.**
2. **C#'ta yapmış olduğunuz form uygulamasının kod kısmına doğru namespace eklenmiş olmalı.** → `using Microsoft.Data.SqlClient;`

---

## Kritik Noktalar 

Bu kısım, bağlantı sürecindeki kritik noktaları hatırlatarak, olası hataların önüne geçmek ve doğru yapılandırmayı sağlamak amacıyla oluşturulmuştur.

> Bağlantı sürecinde dikkate alınması gereken kritik noktalar:

- Belirtilen NuGet paketini projeye yüklediğinizden ve doğru namespace kullandığınızdan emin olun. → [NuGet Paketi Kurma Bölümü](./02-nuget-paketi-kurma.md)
- Kontrol edilmesi gereken bağlantı ayarlarını gözden geçirin ve gerekli kısımlardan emin olun. → [Bağlantı Ayarları Bölümü](./03-baglanti-ayarlari.md)
- SQL **bağlantı cümlenizin (connection string)** doğru yapılandırıldığından emin olun. → [Connection String Böümü](./04-connection-string.md)

---

## Sonuç

Sonuç olarak, bu bölümde karşılaşılabilecek yaygın hataları, bu hataların olası nedenlerini ve çözüm yollarını inceledik. Ayrıca, bağlantı sürecinde dikkat edilmesi gereken temel noktaları hatırlatarak uygulamanın güvenli ve sorunsuz çalışması için sağlam bir temel oluşturduk.

**Böylece, bağlantıdan veri işlemeye kadar tüm adımları kapsayan bu rehberin sonuna geldik. Projeyi kendi ortamınıza uyarlayarak test edebilir ve ihtiyaçlarınıza göre genişletebilirsiniz.**

---
