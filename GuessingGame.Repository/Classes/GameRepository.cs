using GuessingGame.Models;
using GuessingGame.Repository.Interfaces;

namespace GuessingGame.Repository.Classes
{
    public sealed class GameRepository : IGameRepository
    {
        private GameModel _game = new() { NumberToGuess = new Random().Next(0, 10), NumberOfTries = 0 };

        public GameModel GetGame() => this._game;

        public void SaveGame(GameModel game) => this._game = game;
    }
}
