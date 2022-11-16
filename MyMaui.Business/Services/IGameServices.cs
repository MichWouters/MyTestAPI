using MyMaui.Business.Models;

namespace MyMaui.Business.Services;

public interface IGameServices
{
    Task<GameModel> GetGame();
}