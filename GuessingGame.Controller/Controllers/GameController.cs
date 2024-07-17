using GuessingGame.Service;
using Microsoft.AspNetCore.Mvc;

namespace GuessingGame.Controller.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly GameService _service;

        public GameController(GameService gameService) => this._service = gameService;

        [HttpPost("guess")]
        public IActionResult MakeGuess([FromBody] int guess)
        {
            var result = this._service.MakeGuess(guess);
            return Ok(result);
        }
    }
}
