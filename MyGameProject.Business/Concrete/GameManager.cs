using System;
using System.Collections.Generic;
using MyGameProject.Business.Abstract;
using MyGameProject.DataAccess.Abstract;
using MyGameProject.DataAccess.Concrete;
using MyGameProject.Entities.Concrete;

namespace MyGameProject.Business.Concrete
{
    public class GameManager : IGameService
    {
        private IGameDal _gameDal;
        private IPromotionService _promotionService;
        public GameManager(IGameDal gameDal, IPromotionService promotionService)
        {
            _gameDal = gameDal;
            _promotionService = promotionService;
        }

        public void GetList(Games games, Player player)
        {
            List<Games> list = new List<Games> { games };
            var query = _gameDal.GetList(list);
            foreach (var x in query)
            {
                Console.WriteLine(player.PlayerName+" : " +x.GameName + " Price : " + games.GamePrice);
            }
        }

        public void AddGame(Games games, Player player)
        {
            _promotionService.AddPromotion("20% discount available for you");
            _gameDal.Add(games);
            Console.WriteLine(player.PlayerName + " : " + games.GameName + " game added.");
        }

        public void UpdateGame(Games games, Player player)
        {
            _promotionService.UpdatePromotion("20% discount available for you", "50% discount available for you");
            _gameDal.Update(games);
            Console.WriteLine(player.PlayerName + " : " + games.GameName + " game updated.");
        }

        public void DeleteGame(Games games, Player player)
        {
            _promotionService.DeletePromotion("20% discount available for you");
            _gameDal.Delete(games);
            Console.WriteLine(player.PlayerName+" : "+games.GameName + " game deleted.");
        }
    }
}