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

![image](https://github.com/user-attachments/assets/c1bd09d5-ecc5-4ee7-ab73-cd7c072d427a)

---

## Visual Studio'da WinForms Projesi Oluşturma

Visual Studio'yu açın ve bir Windows Forms App (.NET Framework) projesi oluşturun.

**Örneğin;** Form üzerine aşağıdaki bileşenleri ekleyelim.
-**Button;** Veri yüklemek için.
-**2 adet TextBox;** Veri girmek için.
-**DatagridView;** Girdiğimiz verileri görüntülemek için.

Form bileşenlerini ekledikten sonra aşağıdaki gibi adlandırmanız önerilir:

-**txtAd** → Ad için TextBox.
-**txtSoyad** → Soyad için TextBox.
-**btnKaydet** → Buton, verileri yüklemek için kullanılacak.
-**dgvKisiler** → Veritabanından gelen verileri görüntüleyeceğimiz DataGridView.

Aşağıda, form üzerinde bileşenlerin nasıl yerleştirildiğine dair bir örnek form görüntüsü bulunmaktadır.

![image](https://github.com/user-attachments/assets/822fa1a8-81d1-4627-9e4e-077a8ce05061)

Bu adımların sonunda, gerekli arayüz bileşenlerini forma ekleyerek, veritabanı bağlantısında kullanacağımız basit ve kullanıma hazır bir Windows Forms uygulamasını başarıyla oluşturduk.

---