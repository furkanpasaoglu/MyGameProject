using System;
using System.Collections.Generic;
using MyGameProject.Business.Abstract;
using MyGameProject.DataAccess.Abstract;
using MyGameProject.Entities.Concrete;

namespace MyGameProject.Business.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private IPlayerDal _playerDal;
        private IValidationService _validationService;

        public PlayerManager(IPlayerDal playerDal, IValidationService validationService)
        {
            _playerDal = playerDal;
            _validationService = validationService;
        }

        public void GetList(Player player)
        {
            List<Player> list = new List<Player> { player };
            var query = _playerDal.GetList(list);
            foreach (var players in query)
            {
                Console.WriteLine("Player ID  : " + players.PlayerId);
                Console.WriteLine("Player Name : " + players.PlayerName);
                Console.WriteLine("Player Surname : " + players.PlayerSurname);
                Console.WriteLine("Player Date of birth : " + players.DateofBirth);
                Console.WriteLine("Player Balance : " + players.Balance);
                Console.WriteLine();
            };

        }

        public void AddPlayer(Player player)
        {
            bool control =_validationService.ValidationControl(player);
            if (control)
            {
                var query = _playerDal.Add(player);
                Console.WriteLine(query.PlayerName + " player added.");
            }
            else
            {
                Console.WriteLine("player not added.");
            }
            
        }

        public void UpdatePlayer(Player player)
        {
            bool control = _validationService.ValidationControl(player);
            if (control)
            {
                var query = _playerDal.Update(player);
                Console.WriteLine(query.PlayerName + " player updated");
            }
            else
            {
                Console.WriteLine("player not updated.");
            }

        }

        public void DeletePlayer(Player player)
        {
            bool control = _validationService.ValidationControl(player);
            if (control)
            {
                var query = _playerDal.Delete(player);
                Console.WriteLine(query.PlayerName + " player deleted.");
            }
            else
            {
                Console.WriteLine("player not deleted.");
            }

        }
    }
}