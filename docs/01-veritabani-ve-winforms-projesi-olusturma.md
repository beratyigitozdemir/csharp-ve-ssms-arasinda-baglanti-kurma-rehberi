# Veritabanı ve WinForms Projesi Oluşturma

C# ile SQL Server arasında bağlantı kurabilmek için öncelikle bir veritabanına ve bu bağlantıyı kullanacak bir C# uygulamasına ihtiyaç vardır.
Bu rehberde, bir WinForms projesi üzerinden ilerleyeceğiz ve her iki bileşenin nasıl oluşturulacağını adım adım ele alacağız.

Bu bölüm, konuyu yeni öğrenen kullanıcılar için hazırlanmış olup, **temel düzeyde** bir veritabanı ve basit bir form uygulaması oluşturulacaktır.

Deneyimli kullanıcılar bu kısmı atlayıp doğrudan sonraki aşamalara geçebilir.

---

## Veritabanı

Aşağıdaki SQL komutlarıyla **KisiVeritabani** adlı veritabanını oluşturacak ve içine **Kisiler** adlı bir tablo eklemiş olacaksınız.

```sql
CREATE DATABASE KisiVeritabani;
GO

USE KisiVeritabani;
GO

CREATE TABLE Kisiler (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50)
);
```

Bu kodu çalıştırdığınızda aşağıdaki gibi bir çıktı aldıysanız, veritabanını başarıyla oluşturmuşsunuz demektir.

![image](https://github.com/beratyigitozdemir/csharp-ve-ssms-arasinda-baglanti-kurma-rehberi/issues/1#issue-3220350751)

---

