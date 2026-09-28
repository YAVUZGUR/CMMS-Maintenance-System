# CMMS - Bilgisayarlı Bakım ve Arıza Yönetim Sistemi (Dijital Dönüşüm Çözümü)

Bu proje; endüstriyel tesisler, üretim hatları ve tersane gibi operasyonel sahalarda geleneksel (kağıt formlar, Excel vb.) yöntemlerle yürütülen bakım süreçlerini dijitalleştirmek, plansız duruş sürelerini (**downtime**) minimize etmek ve bakım maliyetlerini şeffaf kılmak amacıyla geliştirilmiş katmanlı mimariye sahip bir kurumsal yazılım prototipidir.

---

İş Problemi & Sistem Analizi Yaklaşımı
* **Mevcut Problem:** Sahada arızalanan ekipmanların arıza bildiriminde yaşanan gecikmeler, bakım onay süreçlerinin manuel ilerlemesi ve arıza sıklığı ile yedek parça maliyetleri arasındaki ilişkinin ölçülememesi.
* **Dijital Çözüm:** Operatör düzeyinde anlık arıza kaydı oluşturma, otomatik ekipman durum güncellemeleri (Active -> Defective), duruş süresi hesaplama ve kritik stok uyarı mekanizmaları.

---

Mimari Yapı (N-Tier Architecture)

Proje, kurumsal yazılım geliştirme standartlarına uygun olarak 4 temel katmana ayrılmıştır:

* **`CMMS.Entities`**: Veritabanı tablolarının nesne modellerini barındıran çekirdek katman (`User`, `Asset`, `WorkOrder`, `SparePart`, `WorkOrderPart`).
* **`CMMS.DataAccess`**: Microsoft Entity Framework Core bağlantılarını, DbContext yapılandırmalarını ve veri bütünlüğü kısıtlamalarını yöneten veri erişim katmanı.
* **`CMMS.Business`**: İş kuralları, otomatik makine durum yönetimi ve arıza yaşam döngüsünü yöneten servis katmanı.
* **`CMMS.UI`**: Windows Forms tabanlı kullanıcı arayüzü katmanı.

---

Kullanılan Teknolojiler & Beceriler
* **Dil / Framework:** C# (.NET)
* **Veritabanı & ORM:** Microsoft SQL Server, Entity Framework Core (Code-First / Fluent API)
* **Arayüz:** Windows Forms (WinForms)
* **Yöntemler:** Katmanlı Mimari (N-Tier), Nesne Yönelimli Programlama (OOP), Veritabanı Normalizasyonu, Süreç Analizi

---

Kurulum ve Çalıştırma

1. **Veritabanı Hazırlığı:**
   * SQL Server üzerinde `CMMS_Db` veritabanını oluşturun ve şemayı çalıştırın.
2. **Projeyi Başlatma:**
   * `CMMS_System.sln` çözüm dosyasını Visual Studio ile açın.
   * `CMMS.UI` projesini başlangıç projesi olarak ayarlayıp `F5` tuşu ile çalıştırın.
