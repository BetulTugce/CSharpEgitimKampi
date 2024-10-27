using System;
using System.Data;
using System.Data.SqlClient;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRUD => Create-Read-Update-Delete

            Console.WriteLine("***** Menu *****\n----------------------\n");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategorinin adını girin: ");
            //string categoryName= Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = BETUL; Initial Catalog = CSharpEgitimKampiDb; Integrated Security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Categories (Name) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source = BETUL; initial catalog = CSharpEgitimKampiDb; integrated security = true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Products (Name, Price, Status) values (@name, @price, @status)", connection);
            //command.Parameters.AddWithValue("@name", productName);
            //command.Parameters.AddWithValue("@price", productPrice);
            //command.Parameters.AddWithValue("@status", false);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün eklendi!");
            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source = BETUL; integrated security = true; initial catalog = CSharpEgitimKampiDb;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from Products", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //// İlk döngü tablodaki her bir satırı bir bütün olarak dönerken ikinci döngüde o satır içindeki her bir kolona ait verileri döner..
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source = BETUL; integrated security = true; initial catalog = CSharpEgitimKampiDb;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete from Products where ProductId = @id", connection);
            //command.Parameters.AddWithValue("@id", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün silindi!");
            #endregion

            #region Ürün Güncelleme İşlemi

            Console.Write("Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Ürün Adı: ");
            string productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = BETUL; integrated security = true; initial catalog = CSharpEgitimKampiDb;");
            connection.Open();

            SqlCommand command = new SqlCommand("update Products set Name=@pName, Price=@pPrice where ProductId=@pId", connection);
            command.Parameters.AddWithValue("@pName", productName);
            command.Parameters.AddWithValue("@pPrice", productPrice);
            command.Parameters.AddWithValue("@pId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme başarılı!");
            #endregion

            Console.Read();
        }
    }
}
