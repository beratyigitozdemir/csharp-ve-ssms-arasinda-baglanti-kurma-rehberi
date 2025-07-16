\# Connection String (Bağlantı Cümlesi)



\*\*Connection String\*\*, bir \*\*C# uygulamasının\*\* \*\*SQL Server\*\* veritabanına bağlanabilmesi için gereken \*\*sunucu adı\*\*, \*\*veritabanı adı\*\*, \*\*kimlik doğrulama bilgileri\*\* ve \*\*bağlantı ayarlarını\*\* içeren metinsel ifadedir. Bu yapı, uygulama ile veritabanı arasındaki köprünün kurulmasını sağlar ve bağlantının başarılı olabilmesi için doğru şekilde tanımlanması \*\*kritik öneme\*\* sahiptir.



\*\*Bu bölüm, connection string'in önemini ve doğru şekilde yapılandırılmasının bağlantı sürecindeki rolünü detaylı bir şekilde incelemektedir.\*\*



---



\## Connection String Neden Önemlidir?



Veritabanı bağlantısının başarılı şekilde kurulabilmesi için, \*\*bağlantı cümlesinin\*\* doğru ve eksiksiz tanımlanması gerekir. Connection string içinde sunucu adı, veritabanı adı, kimlik doğrulama yöntemi gibi bilgilerin yer alması, \*\*bağlantı güvenliği\*\* ve \*\*kararlılığı açısından\*\* çok önemlidir.



Hatalı tanımlanmış bir connection string; \*\*bağlantı hatalarına\*\*, \*\*yetki sorunlarına\*\* veya \*\*veritabanına erişememe problemlerine\*\* yol açabilir. \*\*Bu nedenle, bağlantı cümlesinin yapısının ve bileşenlerini iyi anlamak büyük önem taşır.\*\*



---



\## Temel Connection String Yapıları



Connection string yapısı, kullanılan kimlik doğrulama yöntemine göre değişiklik gösterebilir. Bu bölümde en sık kullanılan bağlantı türleri için \*\*temel connection string örneklerini\*\* ve kullanım senaryolarını incelemektedir.



\### 1. Windows Authentication ile Bağlantı



Bu bağlantı türünde, SQL Server'a erişim için uygulamanın çalıştığı Windows oturumundaki kullanıcı kimlik bilgileri kullanılır. \*\*Kullanıcı adı veya parola girilmesine gerek yoktur.



```csharp



string connectionString = "Server=BERAT;Database=KisiVeritabani;Integrated Security=True;TrustServerCertificate=True;";



```



| Bileşen                       | Açıklama                                                                                                                   |

|-------------------------------|----------------------------------------------------------------------------------------------------------------------------|

| `Server=BERAT`                | SQL Server’ın kurulu olduğu bilgisayarın adıdır. SSMS kurulumu sırasında genellikle varsayılan olarak atanır.              |

| `Database=KisiVeritabani`     | Bağlanmak istenilen veritabanının adıdır. Uygulamanın işlemlerini bu veritabanı üzerinden gerçekleştirmesi beklenir.       |

| `Integrated Security=True`    | Windows Authentication kullanıldığını belirtir. Kullanıcı adı/parola yazılmaz, oturum bilgisi otomatik olarak kullanılır.  |

| `TrustServerCertificate=True` | SQL Server’ın SSL sertifikasını doğrulamaz; geliştirme ortamları için uygundur,sertifika eksikliğinden kaynaklanan         |

|				| bağlantı hatalarını önlemek için kullanılır, üretimde önerilmez.  					                     |



Windows Authentication, yerel ve kurumsal ağlarda güvenli bağlantılar için sıkça tercih edilir. Ancak bazı senaryolarda kullanıcı adı ve şifreyle bağlantı gerekebilir. \*\*Sıradaki bağlantı yöntemi tam olarak bu ihtiyacı karşılıyor → SQL Server Authentication\*\*



---

