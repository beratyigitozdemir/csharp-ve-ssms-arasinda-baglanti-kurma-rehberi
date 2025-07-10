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

![image](https://private-user-images.githubusercontent.com/186083101/464885428-c1bd09d5-ecc5-4ee7-ab73-cd7c072d427a.png?jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NTIxNzQzMDAsIm5iZiI6MTc1MjE3NDAwMCwicGF0aCI6Ii8xODYwODMxMDEvNDY0ODg1NDI4LWMxYmQwOWQ1LWVjYzUtNGVlNy1hYjczLWNkN2MwNzJkNDI3YS5wbmc_WC1BbXotQWxnb3JpdGhtPUFXUzQtSE1BQy1TSEEyNTYmWC1BbXotQ3JlZGVudGlhbD1BS0lBVkNPRFlMU0E1M1BRSzRaQSUyRjIwMjUwNzEwJTJGdXMtZWFzdC0xJTJGczMlMkZhd3M0X3JlcXVlc3QmWC1BbXotRGF0ZT0yMDI1MDcxMFQxOTAwMDBaJlgtQW16LUV4cGlyZXM9MzAwJlgtQW16LVNpZ25hdHVyZT1iZjRjMTU4MTAyMzI1NGM2NmM1NzhkOWQwNjM0ZTRmZmVhZGQ4YTY3NWQ4N2JmNjc4NGUzMzI0ZjMwOGI1MjNjJlgtQW16LVNpZ25lZEhlYWRlcnM9aG9zdCJ9.YeEWOD9q021D6ooaRpuA6idDVNK4l_hpYacSKPdcmaM)

---

