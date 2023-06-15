using Microsoft.AspNetCore.Mvc.ViewEngines;
using MongoDB.Driver;

namespace SavageNasRaph1.Server.Models
{
    public class Settings
    {
        public static string connectionUri = "mongodb+srv://MovieReview:kP6rak5X2yneVU3l@cluster0.mzifgtg.mongodb.net/?retryWrites=true&w=majority";
        public static MongoClient client = new MongoClient(connectionUri);
        public static IMongoDatabase db = client.GetDatabase("QuizesDb");
        public static IMongoCollection<Quize> QuizesCollection = db.GetCollection<Quize>("Quizes");
    }
}
