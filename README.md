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
