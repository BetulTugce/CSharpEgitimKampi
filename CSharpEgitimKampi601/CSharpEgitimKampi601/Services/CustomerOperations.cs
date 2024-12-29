﻿using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

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

        public List<Customer> GetCustomers()
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var customers = customerCollection.Find(new BsonDocument()).ToList();
            List<Customer> customerList = new List<Customer>();
            foreach (var c in customers)
            {
                customerList.Add(new Customer
                {
                    CustomerId = c["_id"].ToString(),
                    CustomerName = c["CustomerName"].ToString(),
                    CustomerSurname = c["CustomerSurname"].ToString(),
                    CustomerBalance = decimal.Parse(c["CustomerBalance"].ToString()),
                    CustomerShoppingCount = int.Parse(c["CustomerShoppingCount"].ToString()),
                    CustomerCity = c["CustomerCity"].ToString()
                });
            }
            return customerList;
        }

        public void DeleteCustomer(string id)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            customerCollection.DeleteOne(filter);
        }

        public void UpdateCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
            var updatedValue = Builders<BsonDocument>.Update
                .Set("CustomerName", customer.CustomerName)
                .Set("CustomerSurname", customer.CustomerSurname)
                .Set("CustomerCity", customer.CustomerCity)
                .Set("CustomerBalance", customer.CustomerBalance)
                .Set("CustomerShoppingCount", customer.CustomerShoppingCount);
            customerCollection.UpdateOne(filter, updatedValue);
        }

        public Customer GetCustomerById(string id)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var result = customerCollection.Find(filter).FirstOrDefault();
            return new Customer
            {
                CustomerId = id,
                CustomerName = result["CustomerName"].ToString(),
                CustomerSurname = result["CustomerSurname"].ToString(),
                CustomerCity = result["CustomerCity"].ToString(),
                CustomerBalance = decimal.Parse(result["CustomerBalance"].ToString()),
                CustomerShoppingCount = int.Parse(result["CustomerShoppingCount"].ToString()),
            };
        }
    }
}
