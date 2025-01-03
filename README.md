# C# Eğitim Kampı

Bu repo, **Murat Yücedağ**'ın eğitmenliğinde gerçekleştirilen C# Eğitim Kampı boyunca tamamladığım dersleri içermektedir..
 
## Ders 1 : Merhaba Dünya

İlk derste programlama klasiği olan "Merhaba Dünya" yazarak açılış yaptık. Temel yazdırma komutlarına göz attık.

## Ders 2 : Değişkenler

Değişken tiplerini işledik. Klavyeden veri girişleri yaparak tipler arası dönüşümler gerçekleştirdik. Girilen sınav notlarına göre ortalama hesabı yapan programı yazdık.

## Ders 3 : Karar Yapıları

If-else ve switch-case yapılarına göz atıp çeşitli örnekler yazarak konuyu pekiştirdik. Hesap makinesi örneği ile dersi tamamladık.

## Ders 4 : Döngüler

For ve while döngülerini inceleyip üzerine basit algoritmalar yazdık. Bakteri sorusunu çözdük.

## Ders 5 : Döngüler Devamı

Yıldız sembolü ile döngüleri kullanarak çeşitli şekiller (dik üçgen, piramit, baklava dilimi vb.) ortaya çıkaran algoritmalar yazdık.

## Ders 6 : Diziler

Bir dizi tanımlama, dizinin elemanını/elemanlarını listeleme, dizinin metotları gibi konuları işledik.

## Ders 7 : Foreach Döngüsü

Foreach döngüsünün kullanımına göz atarak örnek bir sınav sistemi uygulaması yazdık.

## Ders 8 : Metotlar

Geriye değer döndüren/döndürmeyen, parametre alan/almayan metotları genel olarak inceleyerek dersi tamamladık.

## Ders 9 : Veritabanı Projesi

Sql Server Management Studio üzerinde bir veritabanı ve çeşitli tablolar oluşturup içerisine örnek veri girişleri yaptık. Temel sql sorguları yazarak verileri listeleme işlemini gerçekleştirdik.

## Ders 10 : CRUD Operasyonları

Sql server veritabanında basit CRUD (Create-Read-Update-Delete) işlemleri gerçekleştirmek üzere bir c# konsol uygulaması yazdık.

### Kullanılan Komutlar ve Sınıflar

#### 1. `SqlConnection`

- **Kullanım**:
```csharp
 SqlConnection connection = new SqlConnection("connection string buraya eklenecek");
```
- **Açıklama**:
`SqlConnection`, SQL Server veritabanına bağlanmak için kullanılır. Connection String içerisinde veritabanı sunucusu, veritabanı adı ve güvenlik ayarları bulunur.

- **Bağlantıyı Açma**:
```csharp
 connection.Open();
```

- **Bağlantıyı Kapatma**:
```csharp
 connection.Close();
```

#### 2. `SqlCommand`

- **Kullanım**:
```csharp
 SqlCommand command = new SqlCommand("sql komutu buraya yazılacak", connection);
```
- **Açıklama**:
Bu sınıf t-sql sorguları ile veritabanı üzerinde select, insert, update ve delete işlemlerini gerçekleştirmek için kullanılır.

- **Parametre Ekleme**:
```csharp
 command.Parameters.AddWithValue("@parametre", deger);
```

- **Sorguyu Çalıştırma**:
  - **`ExecuteNonQuery()`**: Veri döndürmeyen `INSERT`, `UPDATE`, `DELETE` gibi komutları çalıştırır.
  - **`ExecuteReader()`**: Veri döndüren `SELECT` komutları için kullanılır.

#### 3. `SqlDataAdapter`

- **Kullanım**:
```csharp
 SqlDataAdapter adapter = new SqlDataAdapter(command);
```
- **Açıklama**:
`SqlDataAdapter`, `SqlCommand` nesnesiyle elde edilen verileri bir `DataTable`a yüklemek için kullanılır. Genellikle SELECT komutları ile alınan verilerin tabloya aktarılmasını sağlar. Veriyi belleğe yüklediği için bağlantıyı sürekli açık tutmaya gerek kalmaz.

- **Veri Yükleme**:
```csharp
 adapter.Fill(dataTable);
```

#### 4. `DataTable`

- **Kullanım**:
```csharp
 DataTable dataTable = new DataTable();
```
- **Açıklama**:
`DataTable`, `SqlDataAdapter` ile getirilen verileri saklamak için kullanılır. Bu sınıf, SQL sorgusundan gelen verileri tablo formatında tutar ve programda kolayca kullanılmasını sağlar.

- **Veri Yükleme**:
```csharp
 adapter.Fill(dataTable);
```

## Ders 11 : OOP Modülü: C# ile N Katmanlı Mimari - Entity Layer

Bu derste nesne tabanlı programlamaya (OOP) geçiş yaptık. Katmanlı mimaride proje yazacağımız için öncelikle projeyi 4 katmana (`entity layer`, `data access layer`, `business layer` ve `presentation layer`) ayırdık. Veritabanını code first yaklaşımı ile geliştireceğiz. Bu sebeple entity katmanında `Category`, `Product`, `Order` ve `Customer` sınıflarını oluşturup ilgili propertyleri tanımlayarak dersi tamamladık.

### Mimari Nedir? Neden Kullanılır?

Herhangi bir düzen olmadan yazılan kodu anlamak ve devam ettirmek zaman içinde zorlaşır. Mimari, genel olarak bir yapı veya sistem tasarımını anlatan bir terimdir. Yazılım Mimarisi, herhangi bir yazılım sisteminin temelini oluşturur. Oluşturulmak istenen yazılım için sisteminin tasarımının ve organizasyonunun yapılandırılmasıyla ilgilenen disiplindir. İyi bir yazılım mimarisi kodun daha anlaşılır, sürdürülebilir, genişletilebilir olmasını sağlar ve hata yönetimini kolaylaştırır.

### N-Katmanlı Mimari Nedir?

Katmanlı mimari, projeyi çeşitli katmanlara ayıran ve her katmanın kendine ait belirli görevleri üstlendiği bir yapıdır. Katmanlar kendi içlerinde bağımsız çalışabilir ve diğer katmanlarla belirli protokoller üzerinden iletişim kurar. Böylece kod daha modüler ve yönetilebilir hale gelir.

#### 1. Sunum Katmanı (Presentation Layer)

Kullanıcı arayüzünün bulunduğu katmandır. Kullanıcıyla doğrudan etkileşim kurar.

#### 2. İş Mantığı Katmanı (Business Logic Layer)

İş kurallarını ve mantığını içerir. Veri tabanından verilerin hangi şartlar ile getirileceği, ekleme ve güncelleme için veri doğruluğu (validasyon) işlemleri gerçekleştirilir.

#### 3. Veri Erişim Katmanı (Data Access Layer)

Uygulamada kullanılacak veri tabanına veya diğer veri kaynaklarına erişim sağlayan katmandır. Veri okunma, silme, güncelleme veya oluşturma (temel CRUD) gibi işlemleri içerir. Ayrıca veri tabanı bağlantısı için gerekli context sınıfı da bu katmanda bulunur.

#### 4. Varlık Katmanı (Entity Layer)

Bu katman, veritabanı tablolarına karşılık gelen sınıfları barındırır ve bu özellikleri diğer katmanlara referans yoluyla iletir.

### Entity Framework

Microsoft tarafından geliştirilmiştir ve open source bir ORM (Object Relational Mapping) aracıdır. İlişkisel veritabanı ile nesne yönelimli programlama arasında köprü görevi görür. Veritabanı işlemlerini gerçekleştirmek için karmaşık sql sorguları yazma ihtiyacını ortadan kaldırır diyebiliriz.

Entity Framework mimarisinde temelde 3 yaklaşım vardır. `Database First`, `Code First` ve `Model First`.

#### 1. Code First

Projemizde veritabanı işlemlerini Visual Studio tarafında kod yazarak gerçekleştirmemizi sağlayan bir yaklaşımdır. Bu yaklaşıma göre programlama dilindeki class yapısı veritabanındaki tablo yapısını, property ise tablodaki kolon yapısını ifade eder. Attribute kullanarak validasyon kuralları uygulayabiliriz.

#### 2. Database First

Bu yaklaşımda önce veritabanı ve tablolar oluşturulur. Ardından, mevcut veritabanına bağlanarak otomatik olarak (Entity Framework vb. üzerinden) kod modelleri üretilir.

#### 3. Model First

Kod yazmadan ya da serverda fiziksel database ile ilgilenmeden, tamamen entity model üzerinden veritabanı oluşturmak için kullanılan yaklaşımdır. Önce görsel bir model çizilir, çizilen model üzerinden hem veritabanı hem de kod sınıfları otomatik olarak üretilir.

### Access Modifiers

Oluşturulan bir sınıfın ve üyelerinin, methodun vb. erişilebilirlik seviyelerini kontrol etmek için kullanılır. Uygulamadaki farklı bölümlerin birbiriyle nasıl etkileşime girebileceğini belirlememizi ve güvenliği korumamızı sağlar.

- **Public** : Her yerden erişilebilir.

- **Private** : Sadece tanımlandığı class, interface vb. içinde erişime izin verir.

- **Protected** : Tanımlandığı sınıfta ve o sınıfı miras alan sınıflardan erişim sağlanır.

- **Internal** : Sadece bulunduğu assembly içinde kullanılabilirler.

## Ders 12 : OOP Modülü: Data Access Katmanı ve Context Sınıfı

Önceki derste entity katmanında oluşturduğumuz sınıflar arasında ilişkiler kurduk. `NuGet Package Manager` aracılığıyla `EntityFramework` paketini entity ve presentation katmanına kurduk. Katmanlar arası haberleşmeyi gerçekleştirmek için birbirlerine referans gösterdik. Entity katmanını Data Access katmanına, Data Access katmanını Business katmanına ve Business katmanını Presentation katmanına referans olarak verdik. Context sınıfı oluşturup tabloları ekledik. Son olarak Presentation katmanında App.Config içerisine connection stringi tanımlayarak dersi tamamladık.

### DbContext Sınıfı

Entity Framework'ün temel sınıfıdır. Veritabanı işlemlerini yönetmek için kullanılır.

### DbSet Sınıfı

Entity Framework'te belirli bir varlık türünü yani entityi temsil eden koleksiyonları yönetmek için DbSet<T> sınıfı kullanılır.
Her DbSet, veritabanındaki bir tabloya karşılık gelir.

## Ders 13 : OOP Modülü: Migration İşlemleri ve Abstract Interfaceler

Bu derste migration işlemini gerçekleştirdik ve interfaceleri yazdık.

### Migration

`Migration`, ***göç*** anlamına gelmektedir. `Migration` işlemi, DbContext sınıfı üzerinden projemizdeki entity classları aracılığıyla kurduğumuz yapıyı veritabanına yansıtmamızı sağlar. 

### Interface

Bir sınıfın hangi işlevleri (create, update vb.) gerçekleştirmesi gerektiğini belirler ama bunun nasıl yapılacağı ile ilgilenmez.

## Ders 14 : Orm Yapısı: Entity Framework DbFirst ve Model Oluşturma

Bu derste SQL Server üzerinde `Guides`, `Locations` ve `Customers` tablolarını barındıran bir veritabanı oluşturduk. DbFirst yaklaşımını kullanarak oluşturduğumuz veritabanını `Entity Data Model Wizard` aracılığıyla model olarak bağladık ve ilgili entitylerin EF tarafından otomatik olarak oluşturulmasını sağladık.

### Database First

Bu yaklaşımda, yazılım projesine başlamadan önce bir veritabanı tasarlanır ve bu tasarıma göre uygulama gerçekleştirilir. `Entity Framework` veya benzeri ORM araçları kullanarak uygulanır. **DbFirst** özellikle mevcut bir veritabanı üzerinde çalışılması gerektiğinde tercih edilen bir yöntemdir.

## Ders 15 : Entity Framework Metotları ile Proje Uygulaması

Bu derste `Guides` tablosunda veritabanı tarafında yaptığımız değişikliğe göre modeli güncelledik. WinFormda basit bir tasarım yaparak `Guides` tablosu için temel CRUD işlemlerini gerçekleştirdik.

## Ders 16 : Entity Framework: Tur Projesi Location İşlemleri

Bu derste winFormda basit bir tasarım yaparak `Locations` tablosu için temel CRUD işlemlerini gerçekleştirdik.

## Ders 17 : Entity Framework Metotları ve Linq Sorgular

Bu derste, **İstatistikler** sayfası oluşturduk ve `EF Core` ile `LINQ` sorguları yazarak dersi tamamladık.

![FrmStatistics](https://github.com/user-attachments/assets/304aec72-05a6-4609-944f-692455dc6b74)

## Ders 18 : EntityState Komutları, Generic Repository Sınıfı ve Ef Sınıfları

`IGenericRepository` arayüzünde tanımladığımız içi boş metotları `GenericRepository` sınıfını yazarak doldurduk. Ardından her bir entity için `GenericRepository`'den miras alan özel repository sınıflarını oluşturduk ve ilgili sınıflarda kendi arayüzlerini implement ettik. 

## Ders 19 : Business Katmanı ve Logic Kurallar

Business katmanının ne olduğunu, ne işe yaradığını gözden geçirdik. Ardından oluşturduğumuz `IGenericService` arayüzüne `IGenericRepository`de tanımladığımız içi boş metotları ekledik ve her bir entity için custom manager sınıfları oluşturup CRUD işlemleri için eklediğimiz metotların içlerini doldurduk. Kategori işlemleri için form oluşturarak basit bir tasarım hazırladık.

## Ders 20 : Dependency Injection

Dependency injectionın ne olduğu ve nasıl uygulandığı hakkında teorik bilgileri gözden geçirdik. Ardından bir önceki ders hazırladığımız kategori formunu dinamik hale getirdik. Kategori ile ilgili CRUD işlemlerini gerçekleştirdik.

### Dependency Injection Nedir?

Bağımlılık oluşturacak parçaların ayrılıp, bunların dışardan verilmesiyle sistem içerisindeki bağımlılığı minimize etme işlemidir.
Yani, oluşturacağımız bir sınıf içerisinde başka bir sınıfın nesnesini kullanacaksak new anahtar sözcüğüyle oluşturmamamız gerektiğini söyleyen bir yaklaşımdır. Kodun test edilebilirliğini ve bakımını kolaylaştırır.

## Ders 21 : Entitye Özgü Metot Yazmak

Ürünler için CRUD operasyonlarını gerçekleştirebilmek amacıyla bir form oluşturduk. `Product` entitysine özel olarak kategori adıyla beraber ürün bilgilerini getiren metot yazdık. Listeleme ve silme işlemlerini gerçekleştirdik.

## Ders 22 : C# ile Dapper Kullanımı

`Product` için ekleme, güncelleme ve idye göre getirme işlemleri gerçekleştirerek eğitimin 301 modülünü tamamladık. Dapperın ne olduğunu ve nerede kullanıldığını inceledik. Ardından yeni bir veritabanı ve winForm uygulaması oluşturarak eğitimin 501 modülüne geçiş yaptık. Dapper paketini kurduk, dtolarımızı ve interfaceimizi yazarak dersi tamamladık.

## Ders 23 : Dapper İşlemlerinin Tamamlanması

Önceki derste oluşturduğumuz formda dapper aracılığıyla ekleme, silme, güncelleme ve listeleme işlemlerini gerçekleştirdik ve formu dinamik hale getirdik. Sonrasında toplam kategori sayısı, en pahalı ürün gibi istatistikleri getirmek için sorgular yazarak dersi tamamladık.

## Ders 24 : C# ile MongoDb Kullanımı 1

Eğitimin 601 modülüne geçtik. MongoDbnin ne olduğu, özellikleri ve avantajları hakkında bilgi edindik. Yeni bir proje oluşturarak basit bir form tasarımı yaptık. Ardından `Customer` entitysini oluşturduk. Servis yazarak ekleme işlemini gerçekleştirdik.

## Ders 25 : C# ile MongoDb Kullanımı 2

Customer için ekleme işlemini önceki ders gerçekleştirmiştik. Geri kalan CRUD işlemleri için servisi ve formu güncelleyerek dersi tamamladık.

## Ders 26 : C# ile PostgreSQL Kullanımı 1

PostgreSQL hakkında genel bilgileri kısaca gözden geçirdik. Ardından `CustomerDb` adında örnek bir veritabanı ve `Customers` tablosu oluşturduk. 601 altında yeni bir form sayfası oluşturarak CRUD işlemlerini gerçekleştirdik. 

### PostgreSQL

Tamamen ücretsiz ve açık kaynaklı, güçlü bir veritabanı yönetim sistemidir.

#### NpgsqlCommand

PostgreSQL veritabanına sorgu göndermek için kullanılır.

#### NpgsqlDataAdapter

PostgreSQL'deki verilerle DataSet gibi nesneler arasında köprü görevi görür. Genellikle verileri veritabanından alıp bir `DataSet` veya `DataTable` nesnesine yüklemek ve daha sonra bu verileri manipüle edip veritabanına geri yazmak için kullanılır.

## Ders 27 : C# ile PostgreSQL Kullanımı 2

`Employee` formu ekleyerek basit bir sayfa oluşturduk. `CustomerDb` üzerinde sorgu yazarak `Employees` ve `Departments` tablolarını oluşturduk. Örnek veri girişi yaptık. Form sayfasında listeleme ve ekleme işlemini gerçekleştirdik.