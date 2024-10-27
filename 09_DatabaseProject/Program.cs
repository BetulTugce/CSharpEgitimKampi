using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net => C#da sql yapılarını kullanabilmemize olanak tanıyan bir çerçeve.
            Console.WriteLine("***** Ürün-Sipariş Bilgi Sistemi *****\n\n\n-------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış");
            Console.Write("Lütfen bir seçim yapınız: ");
            short selectedMenu = short.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection("Data Source = BETUL; initial Catalog=CSharpEgitimKampiDb; integrated security=true;");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Categories", connection);
            // SqlDataAdapter => C# tarafında oluşturulan sorguyla sql veritabanı arasında köprü görevi görecek olan sınıf. 
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable => Verileri geçici belleğe yani rame almayı sağlar.
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
