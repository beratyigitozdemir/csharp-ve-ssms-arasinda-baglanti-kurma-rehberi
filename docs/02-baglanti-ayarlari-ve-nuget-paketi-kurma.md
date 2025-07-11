# NuGet Paketi Kurulumu ve Bağlantı Ayarları 

C# ile SQL Server arasında sağlıklı bir bağlantı kurabilmek için bazı teknik gerekliliklerin karşılanması gerekir. Bu bölümde, projeye gerekli NuGet paketini nasıl ekleyeceğimiz ve SQL Server tarafında kontrol edilmesi gereken temel bağlantı ayarları adım adım açıklanmaktadır.

---

## Microsoft.Data.SqlClient NuGet Paketi Kurulumu

SQL Server'a C# üzerinden bağlanabilmek için bu bağlantıyı yönetecek özel bir kütüphane gereklidir. Bu bağlantıyı sağlayan en güncel ve desteklenen paket **Microsoft.Data.SqlClient** isimli NuGet paketidir.

Bu paket olmadan **SqlConnection**, **SqlCommand** ve **SqlDataAdapter** gibi temel bileşenlere erişilemez ve veritabanı işlemleri yapılamaz.

### Nasıl Kurulur?

1. Visual Studio'da **Çözüm Gezgini** panelinden projenize sağ tıklayın.
2. Açılan menüden **NuGet Paketlerini Yönet** seçeneğine tıklayın.

![image](https://github.com/user-attachments/assets/25fae2ca-5731-4b67-b822-85b9fc35dd86)

3. Üst sekmeden **Gözat** kısmına gelin.
4. Arama çubuğuna **Microsoft.Data.SqlClient** yazın.
5. En güncel sürümünü seçin ve **Install (Yükle)** butonuna tıklayın.

![image](https://github.com/user-attachments/assets/1530b956-835f-4d19-a14d-f64d19a98afe)

6. Paketi yükledikten sonra aşağıdaki namespace'i projenize eklemeniz zorunludur; aksi takdirde bağlantı bileşenleri projede tanımlanamaz.

```csharp

using Microsoft.Data.SqlClient;

```

Bu adımlarla birlikte **NuGet paketi** kurulumunu tamamladık ve gerekli namespace tanımlamasını yaptık. Şimdi, bağlantının sorunsuz çalışabilmesi için SQL Server tarafındaki bağlantı ayarlarını kontrol edeceğiz.

---
