using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;

namespace CSharpEgitimKampi601.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            // MongoDbye baglanti isteginde bulunuyor..
            var connection = new MongoDbConnection();
            // Tabloya baglaniyor..
            var customerCollection = connection.GetCustomersCollection();
            // Parametreleri gonderiyor..
            var document = new BsonDocument
            {
                {"CustomerName", customer.CustomerName},
                {"CustomerSurname", customer.CustomerSurname},
                {"CustomerCity", customer.CustomerCity},
                {"CustomerBalance", customer.CustomerBalance},
                {"CustomerShoppingCount", customer.CustomerShoppingCount}
            };
            // Ekleme islemi yapiliyor..
            customerCollection.InsertOne(document);
        }


    }
}
