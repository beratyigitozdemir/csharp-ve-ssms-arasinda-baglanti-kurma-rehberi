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
> Bu namespace'i kullanabilmek için önceki adımlarda da gösterildği gibi 
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

---