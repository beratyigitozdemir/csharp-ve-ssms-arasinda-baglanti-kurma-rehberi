# Kontrol Edilmesi Gereken Bağlantı Ayarları

Bu bölüm, hem **SQL Server ayarlarında** hem de **SSMS** arayüzü üzerinden kontrol edilmesi gereken bağlantı yapılandırmalarını adım adım incelemektedir. Bu kontroller, C# uygulamasının SQL Server'a doğru ve güvenli bir şekilde bağlanabilmesi için gereklidir.

---

## SQL Server Servisi Çalışıyor mu?

Bağlantının kurulabilmesi için **SQL Server** servisinin aktif ve çalışır durumda olması gerekir. Aşağıdaki iki yöntemle bu durumu kontrol edebilirsiniz:

### 1. SQL Server Configuration Manager

Servislerin aktif olup olmadığını en güvenilir şekilde görebileceğiniz yer SQL Server Configuration Manager'dır.

1. **SQL Server Configuration Manager** uygulamasını açın.
2. Sol menüde **SQL Server Services** seçeneğine tıklayın.
3. Sağ tarafta yer alan servislerden **SQL Server (MSSQLSERVER)** satırındaki durumun **Running** olduğundan emin olun.

![image](https://github.com/user-attachments/assets/0295e1cb-52c4-4014-9474-f4f858efa1aa)

### 2. Windows Hizmetler Ekranı Üzerinden SQL Server Servisi Kontrolü

Alternatif olarak, SQL Server servisinin çalışıp çalışmadığını bu yöntemle de kontrol edebilirsiniz.

1. Başlat menüsünü açın ve arama kutusuna **services.msc** yazın ve ardından Enter tuşuna basarak hizmetler ekranını açın.

![image](https://github.com/user-attachments/assets/62abeff8-99ce-451b-a7dc-be33a4fdf52d)

2. Açılan listede, **SQL Server (MSSQLSERVER)** veya sizin kullandığınız sürüme göre adlandırılmış **SQL Server (SQLEXPRESS)** gibi bir servis bulun.
3. Bu servisin **Durum** sütununda **Çalışıyor** (Running) yazdığından emin olun.
4. Eğer servis çalışmıyorsa servise sağ tıklayın ve başlat seçeneğine tıklayın.

![Image](https://github.com/user-attachments/assets/9f72316a-02c6-4df7-a908-fa496bac26c5)

5. Servisin **Başlangıç Türü** kısmı **Otomatik** olarak ayarlanmışsa, sistem her açıldığında bu servis otomatik başlar. Değilse, isteğe bağlı olarak değiştirebilirsiniz.

#### Not:

- Eğer listede SQL Server servisini göremiyorsanız, kurulum sırasında servis adı farklı verilmiş olabilir.
- **MSSQLSERVER** → varsayılan örnek
- **SQLEXPRESS** → SQL Express sürümü için yaygın ad

---