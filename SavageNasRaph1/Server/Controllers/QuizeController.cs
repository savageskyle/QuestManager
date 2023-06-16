using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using MongoDB.Driver;
using SavageNasRaph1.Server.Models;

namespace SavageNasRaph1.Server.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class QuizeController : Controller
    {
        private readonly IMongoCollection<Quize> _quizescollection;
        public QuizeController(IMongoClient client)
        {
            _quizescollection = Settings.QuizesCollection;
        }
        [HttpPost]
        public async void PostQuize(Quize quize)
        {
            await _quizescollection.InsertOneAsync(quize);
        }
        [HttpGet("{ConnectionId}")]
        public async Task<List<Question>> GetQuize(string QuizeId)
        {
            var quize= await _quizescollection.FindAsync(q => q.ConnectionId == QuizeId);
            return quize.First().Questions;
        }
        [HttpGet("ResultId")]
        public async Task<List<KeyValuePair<string,int>>> GetResults(string ResultId)
        {
            var quize = await _quizescollection.FindAsync(q => q.ConnectionId == ResultId);
            return quize.First().Marks;
        }
    }
}
