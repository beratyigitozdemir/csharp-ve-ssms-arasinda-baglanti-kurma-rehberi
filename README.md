# C# ile SSMS Arasında Bağlantı Kurma - Rehber

Bu rehber, C# uygulamaları ile SQL Server Management Studio (SSMS) arasında bağlantı kurma sürecini kapsamlı bir biçimde ele alır. Bağlantı için izlenmesi gereken adımları, **Connection String** gibi kritik noktaları birlikte açıklayarak, güvenli ve kararlı bir bağlantının nasıl sağlanacağını göstermeyi hedefler.

---
## Rehberin Amacı

C# ile SQL Server arasında bağlantı kurma sürecine dair temel kavramları bilmeyen kullanıcılar için açıklayıcı bilgiler sunmak; konuya aşina olan geliştiriciler için hatırlatıcı ve referans niteliğinde bir kaynak sağlamak amaç edinmiştir.

> İki farklı kullanıcı kitlesine hitap etmektedir:

### 1. Temel Bilgiye İhtiyaç Duyanlar

**Hedef Kitle:** Veritabanı bağlantısı kurma sürecine yeni başlayan ya da C# ile SQL Server arasında bağlantı kurma konusunda deneyimi olmayan kişiler.

- C# uygulamaları ile SQL Server arasında nasıl bağlantı kurulacağını adım adım açıklamak.
- **Connection String** (bağlantı cümlesi) yapısını tanıtıp öğretmek.
- SQL Server yapılandırma ve temel ayarlarını sade bir dille anlatmak.

### 2. Deneyimli Geliştiriciler

**Hedef Kitle:** Daha önce veritabanı bağlantısı kurmuş ancak süreçteki detayları gözden geçirmek veya yeniden yapılandırmak isteyen geliştiriciler.

- **Bağlantı güvenliği**, **şifreleme seçenekleri** ve **bağlantı protokollerine** dair önemli detayları özetlemek.
- **Farklı bağlantı türleri** ve **kimlik doğrulama yöntemlerine** (Windows Authentication ve SQL Authentication gibi) hızlı bir bakış sunmak.
- Kısayol niteliğinde kullanılabilecek, teknik referans bölümleri oluşturmak.

---

## Proje Yapısı

```

📁 csharp-ve-ssms-arasinda-baglanti-kurma-rehberi/
│
├── 📁 baglanti-adimlari/
│   ├── 📖 01-veritabani-ve-winforms-projesi-olusturma.md
│   ├── 📖 02-nuget-paketi-kurulumu.md
│   ├── 📖 03-kontrol-edilmesi-gereken-baglanti-ayarlari.md
│   ├── 📖 04-connection-string.md
│   ├── 📖 05-sql-verisini-csharp-tarafinda-kullanma.md
│   ├── 📖 06-olasi-hatalar-ve-kritik-noktalar.md
│   └── 📝 README.md
│
├── 📁 sqlserverconnection/
│   ├── 📁 sqlserverconnection/
│   │   ├── 🧩 Form1.cs
│   │   ├── 🧩 Form1.Designer.cs
│   │   └── 🧩 Program.cs
│   ├── 🛠️  sqlserverconnection.sln
│   └── 📝 README.md
│
├── © LICENSE
└── 📝 README.md

```

## Reponun Cihaza Klonlanması

> Bu repoyu kendi cihazınıza indirip proje dosyalarına erişmek istiyorsanız, aşağıdaki komutu terminalinize (veya Git Bash'e) yazabilirsiniz:

```bash

git clone https://github.com/beratyigitozdemir/csharp-ve-ssms-arasinda-baglanti-kurma-rehberi.git

```
 
## İçerik

Aşağıdaki içerik tablosu, bu rehberde ele alınan konulara hızlı erişim sağlayacak şekilde yapılandırılmıştır. Başlıklara tıklayarak doğrudan ilgili bölümlere geçiş yapabilirsiniz. 

- [Veritabanı Oluşturma](baglanti-adimlari/01-veritabani-ve-winforms-projesi-olusturma.md)
- [WinForms Projesi Oluşturma](https://github.com/beratyigitozdemir/csharp-ve-ssms-arasinda-baglanti-kurma-rehberi/blob/main/baglanti-adimlari/01-veritabani-ve-winforms-projesi-olusturma.md#visual-studioda-winforms-projesi-olu%C5%9Fturma)
- [NuGet Paketi Kurma](baglanti-adimlari/02-nuget-paketi-kurulumu.md)
- [Kontrol Edilmesi Gereken Bağlantı Ayarları](baglanti-adimlari/03-kontrol-edilmesi-gereken-baglanti-ayarlari.md)
- [Connection String](baglanti-adimlari/04-connection-string.md)
- [SQL Verisini C#'ta Kullanma](baglanti-adimlari/05-sql-verisini-csharp-tarafinda-kullanma.md)
- [Olası Hatalar ve Kritik Noktalar](baglanti-adimlari/06-olasi-hatalar-ve-kritik-noktalar.md)

> Öneri:
Rehberin tamamından en iyi şekilde faydalanabilmek için, aşağıdaki bağlantılara geçmeden önce `README` dosyasını **dikkatlice incelemeniz** tavsiye edilir.

`README` **dosyası için tıklayın** → [README](baglanti-adimlari/README.md)

---

## Lisans

Bu repodaki içerikler [MIT Lisansı](LICENSE) ile korunmaktadır.

© 2025 Berat Yiğit Özdemir

---

| Kriter               | Edge AI                                                                 | Cloud AI                                                                 |
|------------------------|-------------------------------------------------------------------------|--------------------------------------------------------------------------|
| **Çalışma Yeri**    | Cihaz üzerinde (telefon, kamera, IoT, araç)                             | Bulut sunucuları (AWS, Google Cloud, Azure vb.)                          |
| **Gecikme**         | Çok düşük – anlık karar verebilir (milisaniye düzeyi)                   | Daha yüksek – veriler buluta gidip geldiği için gecikme olabilir               |
| **Bağımlılık**     | İnternet olmadan çalışabilir                                            | İnternet bağlantısı zorunlu                                              |
| **Gizlilik**        | Veriler cihazdan çıkmaz, daha güvenlidir                                | Veriler buluta gider → gizlilik riski daha yüksek                        |
| **İşlem Gücü**      | Sınırlı (küçük, optimize edilmiş modeller çalıştırılabilir)             | Çok yüksek (devasa AI modelleri ve büyük veri kümeleri işlenebilir)         |
| **Enerji**             | Cihaz bataryasına yük bindirebilir, düşük güç için optimize gerekir     | Sunucu tarafında enerji yoğun ama cihaz için yük yok                     |
| **Maliyet**          | Başlangıçta cihaz optimizasyonu maliyetli olabilir ama uzun vadede ucuz | Kullanım başına ücret (cloud servis abonelikleri, API çağrıları)             |
| **Örnek**          | Yüz tanıma, IoT cihazları, otonom araç, sağlık cihazları               | ChatGPT, Google Translate, Netflix önerileri, banka dolandırıcılık analizi |
| **Güçlü Yönü**       | Hız, gizlilik, bağımsızlık                                              | Ölçeklenebilirlik, yüksek işlem gücü, büyük veri analizi                 |
| **Zayıf Yönü**          | Donanım sınırlamaları, büyük modelleri çalıştıramaz                    | Gizlilik sorunları, internet bağımlılığı, gecikme                        |



---