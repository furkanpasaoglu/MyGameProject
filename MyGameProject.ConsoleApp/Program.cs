using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using MyGameProject.Business.Abstract;
using MyGameProject.Business.Concrete;
using MyGameProject.Business.Concrete.Promotions;
using MyGameProject.Business.Concrete.Validation;
using MyGameProject.DataAccess.Abstract;
using MyGameProject.DataAccess.Concrete;
using MyGameProject.Entities.Concrete;

namespace MyGameProject.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game-Player";
            //Bunlar Tamamen Implement Dependency Injection olayı.
            //Mvc de başka türlü kullandığım için burada kullandığımda null geliyor du internetten araştırarak bu sonucu buldum.
            //Business ve Console Yüklü Olan Kütüphaneler : Microsoft.Extensions.DependencyInjection
            var container = Program.ConfigureService();
            var playerService = container.GetRequiredService<IPlayerService>();
            var gameService = container.GetRequiredService<IGameService>();
            //////////////////////////////////////////////////////////////////////////
            Player player1 = new Player
            {
                PlayerId = 1,
                NumberId = "12345678910",
                PlayerName = "Furkan",
                PlayerSurname = "Paşaoğlu",
                DateofBirth = "06/08/1999",
                Balance = 150
            };
            Games game1 = new Games
            {
                GameId = 1,
                GameName = "GTA 5",
                GamePrice = 350
            };
            Games game2 = new Games
            {
                GameId = 2,
                GameName = "NFS",
                GamePrice = 125
            };
            Player player2 = new Player
            {
                PlayerId = 2,
                NumberId = "12345678911",
                PlayerName = "Talha",
                PlayerSurname = "Paşaoğlu",
                DateofBirth = "06/08/2005",
                Balance = 350
            };
            //Add Player - Add Game
            ColorRed();
            Console.WriteLine("Oyuncu Ekleme İşlemleri:");
            ColorGreen();
            playerService.AddPlayer(player1);
            playerService.AddPlayer(player2);
            Console.WriteLine();
            ColorRed();
            Console.WriteLine("Oyun Ekleme İşlemleri:");
            ColorGreen();
            gameService.AddGame(game1,player1);
            Console.WriteLine();
            //Update Player
            ColorRed();
            Console.WriteLine("Oyuncu Güncelleme İşlemleri:");
            ColorGreen();
            playerService.UpdatePlayer(player1);
            Console.WriteLine();
            ColorRed();
            Console.WriteLine("Oyun Güncelleme İşlemleri:");
            ColorGreen();
            gameService.UpdateGame(game1,player2);
            Console.WriteLine();
            //Deleted Player
            ColorRed();
            Console.WriteLine("Oyuncu Silme İşlemleri:");
            ColorGreen();
            playerService.DeletePlayer(player2);
            Console.WriteLine();
            ColorRed();
            Console.WriteLine("Oyun Silme İşlemleri:");
            ColorGreen();
            gameService.DeleteGame(game2,player1);
            Console.WriteLine();

            ColorRed();
            Console.WriteLine("Oyuncu Listeleme İşlemleri:");
            ColorGreen();
            playerService.GetList(player1);
            playerService.GetList(player2);
            Console.WriteLine();
            ColorRed();
            Console.WriteLine("Oyun Listeleme İşlemleri:");
            ColorGreen();
            gameService.GetList(game1,player1);
            gameService.GetList(game2,player2);
            Console.ReadLine();
        }

        //DependencyInjection Configure
        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                .AddSingleton<IPlayerService, PlayerManager>()
                .AddSingleton<IPlayerDal, PlayerDal>()
                .AddSingleton<IValidationService,ValidationManager>()
                .AddSingleton<IGameService,GameManager>()
                .AddSingleton<IGameDal,GameDal>()
                .AddSingleton<IPromotionService,PromotionManager>()
                .BuildServiceProvider();
            return provider;
        }
        public static void ColorRed()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
        }
        public static void ColorGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
