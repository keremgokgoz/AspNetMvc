ASP.Net(.Net Framework) C# olan app i seçelim.
MVC (Model View Controller) Model(Veri Tabanı)-View(Frontend)-Controller(Backand)

Deneme Controller ına view eklemek için;
Deneme Metoduna sağ tık yapıp view i seçiyoruz.
View klasörü altında Shared klasörü altında
Açılam pencerede layout page i seçiyoruz.

 <li>@Html.ActionLink("İletişim", "Contact", "Home")</li>
 1. Butonun üzerine yazmak istediğim ad
 2. Controller içindeki metodumun adı
 3. View içindeki hangi klasörde olduğu

 Deneme sayfasını ekledik.
 Layout sayfasına;
  <li>@Html.ActionLink("Deneme", "Deneme", "Home")</li>
  ekledik

  Aynı şekilde Test sayfasını yaptık.

  Yeni bir Layout Page yaptık.
  Layout Page içine diğer sayfaların hangi alanda görüntüleneceğini belirtmek için @RenderBody(); kodunu kulklandık.

  Yeni bir Layout nasıl oluşturulur ?
  Shared Folder ına sağ tıklayıp View ı seçtik
  Alttaki seçenekler seçili olmayacak.
  Oluşan Layout Page e body içinde istedğimiz div içerisine @RenderBody() kodunu yazdık.

  Solution - Add - New Project - Class Library(.NetFramework) C#
  Projemize 4 katman ekledik.
  1. EntityLayer (Tablolar -> Class - Sütun -> Property)
  2. DataAccessLayer (CRUD İşlemleri)
  3. BusinessLayer
  4. PresationsLayer (UI- User Interface)

  EntityLayer
  Katmanın içine Concreate Klasörü oluşturuyoruz.

  Oluşturulacak Tablolar
  1. Writer(Yazar)
  2. Category()
  3. Heading()
  4. Context
  5. About()
  6. Contact()

  İlişki Oluşturma;
  Bire çok olan ilişkide bir olan tarafa koleksiyon ekliyoruz. public ICollection<Heading>Headings{ get; set; }
  Çok tarafına bağlanacak olan tablonun class ve sütunu ekleni.
  public int CategoryID { get; set; }  //bağlayacağımız sütunu ekledik.
        public virtual Category Category { get; set; }

EntityLayer ın içideki Referance ye sağ tılayıp NuGet e tıklayıp Browse alanından EntityFramework 6.4.4 ü install ediyoruz.

DataAccessLayer
Concreate klasörü oluştur, Context sınıfı oluştur içine. NuGet dan Entityframework son sürümü yüklüyoruz. Data access layeri seçip.
Referanlardan EntityLayer katmanını ekledik. DBContexti kalıtım olarak aldık.

UI
Webconfig in içine connectionString ekledik. initial catalog içine veri tabanına vermek istediğimiz name i verdik.

Migrations Ekleme İşlemi
View-> Other Windows -> Package Manager Console a tıklanıyor.




































