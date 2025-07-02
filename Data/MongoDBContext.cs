// THIS FILE HANDLES THE MONGODB CONNECTION SETUP

using MongoDB.Driver;
using Pastry_And_Pour_Jurczak.Models;

namespace Pastry_And_Pour_Jurczak.Data
{
    public class MongoDBContext
    {
        // CONNECTION STRING TO CONNECT TO MY MONGODB ATLAS DATABASE
        private readonly string _connectionString = "mongodb+srv://ajurczak:B@rr3tt_M@1ch05-@cluster0.stwfu1e.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

        // MONGODB CLIENT USED TO ACCESS THE DATABASE
        private readonly IMongoDatabase _database;

        // CONSTRUCTOR THAT SETS UP THE CONNECTION TO DATABASE
        public MongoDBContext()
        {
            var client = new MongoClient(_connectionString);
            _database = client.GetDatabase("pastry_pour_db"); // NAME OF MY DATABASE
        }

        // PUBLIC GETTERS TO ACCESS EACH COLLECTION IN THE DATABASE
        public IMongoCollection<PastryItem> Pastries =>
            _database.GetCollection<PastryItem>("Pastries");

        public IMongoCollection<DrinkItem> Drinks =>
            _database.GetCollection<DrinkItem>("Drinks");

        public IMongoCollection<MenuItem> MenuItems =>
            _database.GetCollection<MenuItem>("Menu_Items");

        public IMongoCollection<Order> Orders =>
            _database.GetCollection<Order>("Orders");

        public IMongoCollection<OrderStatus> OrderStatus =>
            _database.GetCollection<OrderStatus>("Order_Status");
    }
}
