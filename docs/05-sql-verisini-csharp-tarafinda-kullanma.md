# SQL Verisini C#'ta Kullanma

Bir önceki bölümde, **C# uygulamalarının veritabanına bağlanabilmesi için gerekli olan Connection String yapısı** detaylı şekilde incelenmiştir.

Bu bölüm ise oluşturduğumuz connection string'i uygulama tarafında nasıl kullanacağımızı gösteren, temel ama öğretici bir örnekle ilerlemektedir.

> **Uygulamanın işleyişi:**

- **Kullanıcı formdan ad ve soyad bilgisi girer.**
- **Veriler veritabanına eklenir.**
- **Kayıtlı tüm kişiler DataGridView üzerinden görüntülenir.**

---

## SQL İşlemleri için Form Uygulaması

Önceki bölümlerde bir **Windows Forms uygulaması** oluşturmuş, form bileşenlerini eklemiş ve adlandırmıştık.

**Aşağıda, oluşturduğumuz formun arayüzüne yeniden göz atalım:**

![image](https://github.com/user-attachments/assets/822fa1a8-81d1-4627-9e4e-077a8ce05061)

Bu arayüz ile veritabanı arasında bağlantıyı sağlayacak ve işlevleri görecek C# kodlarını inceleyeceğiz.

---

## Formdan Alınan Verileri SQL Server'a Gönderme

Bu kısım, uygulamanın SQL Server ile etkileşim kurmasını sağlayan kodları parça parça inceleyecek ve bağlantı için önemli olan satırları detayli bir açıklayacaktır.

**Böylece yalnızca bu kodu kullanmakla kalmayacak, arkasındaki mantığı ve işleyişi de anlayarak öğrenmiş olacağız.**

### 1. Gerekli Namespace'ler

```csharp

using Microsoft.Data.SqlClient;
using System.Data;

```

- **using System.Data;** → Veritabanı işlemleri için temel veri sınıflarını (DataTable,DatasSet gibi) kullanılmasını sağlar.
- **using Microsoft.Data.SqlClient;** → Veritabanıyla etkileşim kurmak için ihtiyaç duyduğumuz tüm temel sınıflar bu yapı altında yer alır.

> Dikkat!
> Bu namespace'i kullanabilmek için önceki adımlarda da gösterildiği gibi 
> Microsoft.Data.SqlClient NuGet paketinin projeye eklenmiş olması gerekir.

### 2. Connection String Tanımı

```csharp

string connectionString = "Server=BERAT;Database=KisiVeritabani;Integrated Security=True;TrustServerCertificate=True;";

```

**SQL Server'a bağlanmak için gerekli olan bilgileri içerir:**

- **Server** → Sunucu adı.
- **Database** → Hedef veritabanı.
- **Integrated Security** → Windows kimlik doğrulaması kullanılır.
- **TrustServerCertificate=True** → Sertifika hatalarını yoksayar.

### 3. Form Yüklendiğinde Kayıtları Listeleme

```csharp

private void Form1_Load(object sender, EventArgs e)
{
    KisileriListele();
}

```

- **Form açıldığında**, veritabanındaki kayıtları göstermek için **KisileriListel() metodu** çalıştırılır.

### 4. Kayıtları Listeleme

```csharp

private void KisileriListele()
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        string query = "SELECT * FROM Kisiler";
        SqlDataAdapter da = new SqlDataAdapter(query, connection);
        DataTable dt = new DataTable();
        da.Fill(dt);
        dgvKisiler.DataSource = dt;
    }
}

```

| Kod | Açıklama |
|-------|----------|
| `using (SqlConnection connection = new SqlConnection(connectionString))` | `SqlConnection` sınıfı ile bağlantı nesnesi oluşturulur. `using` bloğu sayesinde bağlantı işi bitince otomatik kapatılır. |
| `string query = "SELECT * FROM Kisiler";` | SQL Server’a gönderilecek olan sorgudur. Bu sorgu, `Kisiler` tablosundaki tüm verileri çeker. |
| `SqlDataAdapter da = new SqlDataAdapter(query, connection);` | `SqlDataAdapter`, veritabanından veri çekmek için kullanılan bir araçtır. Sorguyu çalıştırır ve gelen verileri belleğe aktarır. |
| `DataTable dt = new DataTable();` | Verilerin geçici olarak tutulacağı bir dt adında **bellek içi tablo** (`DataTable`) oluşturulur. |
| `da.Fill(dt);` | `SqlDataAdapter`, SQL Server’dan gelen verileri `dt` adlı tabloya doldurur. |
| `dgvKisiler.DataSource = dt;` | `DataGridView` kontrolü, verileri ekranda göstermek için `dt` tablosunu veri kaynağı olarak kullanır. |

### 5. Yeni Kayıt Ekleme

```csharp

private void BtnKaydet_Click_1(object sender, EventArgs e)
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        try
        {
            connection.Open();
            string query = "INSERT INTO Kisiler (Ad, Soyad) VALUES (@Ad, @Soyad)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Ad", txtAd.Text);
            command.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Kişi kaydedildi.");

            KisileriListele();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Hata: " + ex.Message);
        }
    }
}

```

| Kod | Açıklama |
|-------|----------|
| `using (SqlConnection connection = new SqlConnection(connectionString))` | `SqlConnection` sınıfı ile bağlantı nesnesi oluşturulur. `using` bloğu sayesinde bağlantı işi bitince otomatik kapatılır. |
| `connection.Open();` | Bağlantıyı açar. |
| `string query = "INSERT INTO Kisiler (Ad, Soyad) VALUES (@Ad, @Soyad)";` | `SQL Sorgusu:` Girilen verileri Kisiler tablosuna ekler. |
| `SqlCommand command = new SqlCommand(query, connection);` | Sorguyu ve bağlantıyı SQL'e gönderir. |
| `command.Parameters.AddWithValue(...)` | Sorgudaki `Ad` ve `Soyad` değerlerini TextBox'tan alır. |
| `command.ExecuteNonQuery();` | Veritabanına sorguyu gönderir ve çalıştırır. |
| `KisileriListele();`| Ekleme sonrası güncel listeyi tekrar gösterir. |
| `catch`| Hata oluşursa kullanıcıya mesaj gönderir. |

### Formdan Veritabanına: Sürecin Kısa Özeti

**Kullanıcı Giriş Yapar**
- Ad ve Soyad bilgilerini formdaki TextBox'lara yazar,
- **Kaydet** butonuna tıklar.

**Arka Planda Ne Olur?**
- `SqlConnection` ile bağlantı açılır,
- `SqlCommand` ile INSERT sorgusu çalıştırılır,
- Veri başarıyla eklenince `KisileriListele()` metodu çalıştırılır.

**Sonuç:** DataGridView, yeni eklenen kişiyle birlikte güncellenir.

---

## Sonuç ve Proje Dosyası Hakkında

Bu bölümde, bir C# Windows Forms uygulamasında SQL Server verisiyle nasıl etkileşim kuracağımızı adım adım öğrendik. Hem form üzerindeki kullanıcı girişlerini nasıl veritabanına ekleyeceğimizi hem de eklenen kayıtların nasıl listelendiğini detaylı biçimde inceledik.

**Ayrıca bu örnek projeyi, kolayca inceleyip kendi ortamınızda test edebilmeniz için, bu rehber içerisinde sizinle paylaştım. Böylece anlatılan her adımı doğrudan uygulamalı olarak inceleyebilir ve kendi geliştirme ortamınızda test edebilirsiniz.**

> Dikkat! 
> Paylaşılan projedeki connectionString yapısını, kendinize göre özelleştirmeyi unutmayın. Aksi takdirde bağlantı başarılı bir şekilde kurulamaz.

Örnek Proje Dosyası (ilk olarak `README` dosyasını okuyunuz) → [Projeye Git](../sqlserverconnection)

Bu bölüm, SQL verisini C# tarafında nasıl kullanılacağına dair basit ama işlevsel bir örnek uygulama geliştirmiştir.

Bir sonraki bölümde, bu örnekten yola çıkarak karşılaşabilecek [Olası Hatalara ve Kritik Noktalar](./06-olasi-hatalar-ve-kritik-noktalar.md) kısmına göz atacağız.

---