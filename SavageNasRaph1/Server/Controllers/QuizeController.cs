using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using MongoDB.Driver;
using SavageNasRaph1.Server.Models;

namespace SavageNasRaph1.Server.Controllers
{
    [Route("api/controller")]
    public class QuizeController : Controller
    {
        private readonly IMongoCollection<Quize> _quizescollection= Settings.QuizesCollection;
        public QuizeController(IMongoClient client)
        {
            var database = client.GetDatabase("ReviewsDb");
            _quizescollection = Settings.QuizesCollection;
        }
        [HttpPost]
        public async void PostQuize(Quize quize)
        {
            await _quizescollection.InsertOneAsync(quize);
        }
        [HttpGet("{QuizeId}")]
        public async Task<IAsyncCursor<Quize>> GetQuize(string QuizeId)
        {
            return await _quizescollection.FindAsync(q => q.Id == QuizeId);
        }
    }
}
