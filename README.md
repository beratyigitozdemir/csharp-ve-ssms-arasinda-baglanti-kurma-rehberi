# C# ile SSMS Arasında Bağlantı Kurma - Rehber

Bu rehber, C# ile SQL Server Management Studio (SSMS) arasında bağlantı kurma sürecini detaylı bir şekilde inceler. Bağlantı cümlesi (connection strings), SQL Server yapılandırma ayarları, kimlik doğrulama yöntemleri, şifreleme ve güvenlik önlemleri gibi kritik bileşenlere dair teknik bilgiler sunar.

---
## Rehberin Amacı

Bu rehberin amacı, C# ile SQL Server arasında bağlantı kurma sürecine dair temel kavramları bilmeyen kullanıcılar için açıklayıcı bilgiler sunmak; konuya aşina olan geliştiriciler için ise yapılandırma ve bağlantı süreçlerini hatırlatıcı, referans niteliğinde bir kaynak sağlamaktır.
**İki farklı kullanıcı kitlesine** hitap etmeyi amaçlar:

### 1. Temel Bilgiye İhtiyaç Duyanlar

**Hedef Kitle:** Veritabanı bağlantısı kurma sürecine yeni başlayan ya da C# ile SQL Server arasında bağlantı kurma konusunda deneyimi olmayan kişiler.

**Amaç**
- C# uygulamaları ile SQL Server arasında nasıl bağlantı kurulacağını adım adım açıklamak.
- **Connection String** (bağlantı dizesi) yapısını tanıtıp öğretmek.
- SQL Server yapılandırma ve temel ayarlarını sade bir dille anlatmak.

### 2. Deneyimli Geliştiriciler

**Hedef Kitle:** Daha önce veritabanı bağlantısı kurmuş ancak süreçteki detayları gözden geçirmek veya yeniden yapılandırmak isteyen geliştiriciler.

**Amaç**
- **Bağlantı güvenliği**, **şifreleme seçenekleri** ve **bağlantı protokollerine** dair önemli detayları özetlemek.
- **Farklı bağlantı türleri** ve **kimlik doğrulama yöntemlerine** (Windows Authentication ve SQL Authentication gibi) hızlı bir bakış sunmak.
- Kısayol niteliğinde kullanılabilecek, teknik referans bölümleri oluşturmak.

---