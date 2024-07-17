using GuessingGame.Models;
using GuessingGame.Repository.Interfaces;

namespace GuessingGame.Service
{
    public class GameService
    {
        private readonly IGameRepository _repo;

        public GameService(IGameRepository repository) => this._repo = repository;

        public string MakeGuess(int guess)
        {
            var game = this._repo.GetGame();
            game.NumberOfTries++;

            if (guess == game.NumberToGuess)
            {
                this._repo.SaveGame(new GameModel { NumberToGuess = new Random().Next(0, 10), NumberOfTries = 0 });
                return $"Chungus! You guessed it in {game.NumberOfTries} tries.";
            }
            else if (guess < game.NumberToGuess)
            {
                this._repo.SaveGame(game);
                return "Bombaclat you're guessing too low.";
            }
            else
            {
                this._repo.SaveGame(game);
                return "Too high!";
            }
        }
    }
}
