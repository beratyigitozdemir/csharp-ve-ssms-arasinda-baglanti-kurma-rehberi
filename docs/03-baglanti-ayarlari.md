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

## TCP/IP Protokolü Etkin mi?

SQL Server'ın C# uygulamalarıyla ağ üzerinden iletişim kurabilmesi için **TCP/IP** protokolünün etkin durumda olması gerekir. Bu protokol etkin değilse, özellikle uzak bağlantılarda (örneğin farklı bir cihazdan SQL Server'a erişim) bağlantı kurulamaz.

1. Başlat menüsüne **SQL Server Configuration Manager** yazarak açın.
2. Sol menüden **SQL Server Network Configuration** kısmından **Protocols for MSSQLSERVER** kısmına tıklayın.
3. Sağ paneldeki protokol listesinden **TCP/IP'yi** bulun.
4. Eğer **Disabled** ise, sağ tıklayın ve **Enable** seçeneğine tıklayın.

![image](https://github.com/user-attachments/assets/bb676e48-0df8-467a-9f57-a4ec9e1c24b2)

5. Sol menüde **SQL Server Services** bölümüne geçin.
6. Sağ taraftaki listede **SQL Server** (MSSQLSERVER) servisini bulun.
7. Bu servise sağ tıklayın ve **Restart** seçeneğini tıklayarak değişikliklerin geçerli olmasını sağlayın.

---

## Uzak Bağlantılar (Remote Connections) Etkin mi?

SQL Server'ın uzak istemcilerden bağlantı kabul edebilmesi için sunucu ayarlarında **Allow remote connections to this server** seçeneğinin etkin olması gerekir. Bu ayar kapalıysa, farklı cihazlardan bağlantı kurulamaz.

1. **SQL Server Management Studio** (SSMS) uygulamasını açın ve SQL Server'a bağlanın.
2. Bağlantı kurduğunuz sunucu adına sağ tıklayın ve açılan menüden **Properties** seçeneğine tıklayın.
3. Açılan pencerede sol menüden **Connections** sekmesini seçin.
4. Sağ tarafta yer alan **Allow remote connections to this server** seçeneğinin işaretli olduğundan emin olun.
5. Değişiklik yaptıysanız OK butonuna tıklayarak ayarları kaydedin.

![Image](https://github.com/user-attachments/assets/12f1fa38-fd77-4b74-bc1f-3253062b50f4)

Bu adımlarla birlikte, **SQL Server** ve **SSMS** tarafında bağlantının sağlıklı kurulabilmesi için gerekli olan temel ayarları kontrol etmiş olduk. Sıradaki adımda, en kritik nokta olan [Connection String](./04-connection-string.md) yapısını incelemiş olacağız.

---