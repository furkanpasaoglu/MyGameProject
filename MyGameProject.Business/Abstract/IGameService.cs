
using System.Collections.Generic;
using MyGameProject.Entities.Concrete;

namespace MyGameProject.Business.Abstract
{
    public interface IGameService
    {
        void GetList(Games games,Player player);
        void AddGame(Games games, Player player);
        void UpdateGame(Games games, Player player);
        void DeleteGame(Games games, Player player);
    }
}