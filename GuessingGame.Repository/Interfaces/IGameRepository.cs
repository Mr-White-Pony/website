using GuessingGame.Models;

namespace GuessingGame.Repository.Interfaces
{
    public interface IGameRepository
    {
        GameModel GetGame();
        void SaveGame(GameModel game);
    }
}
