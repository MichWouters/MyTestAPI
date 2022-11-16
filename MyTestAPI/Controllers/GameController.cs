using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using MyTestAPI.Models;

namespace MyTestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private static readonly string[] Genres = new[]
        {
            "First Person Shooter", "RTS", "Strategy", "Adventure", "Battle Royale",
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public GameController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }


        [Route("GetGames"), HttpGet]
        public IEnumerable<Game> GetGames()
        {
            var result = Enumerable.Range(1, 3).Select(index => new Game()
            {
                Title = "Lorem Ipsum",
                Price = Random.Shared.Next(10, 69),
                Genre = Genres[Random.Shared.Next(Genres.Length)]
            })
                .ToArray();
            return result;
        }

        [Route("GetGame"), HttpGet]
        public Game GetGame(int id)
        {
            var result = new Game
            {
                Title = "Dark Souls",
                Price = Random.Shared.Next(10, 69),
                Genre = Genres[Random.Shared.Next(Genres.Length)]
            };

            return result;
        }

        [HttpPost]
        public void AddGame(Game game)
        {
            // Magic happens here
        }
    }
}