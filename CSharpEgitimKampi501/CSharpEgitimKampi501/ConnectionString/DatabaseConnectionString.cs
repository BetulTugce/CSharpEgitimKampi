using System.Data.SqlClient;

namespace CSharpEgitimKampi501.ConnectionString
{
    public static class DatabaseConnectionString
    {
        public static void SQLDatabaseConnectionString()
        {
            SqlConnection connection = new SqlConnection("Server=BETUL;initial Catalog=CSharpEgitimKampi501Db;integrated security=true;");
        }
    }
}
