using System;
using MyGameProject.Business.Abstract;
using MyGameProject.Entities.Concrete;

namespace MyGameProject.Business.Concrete.Validation
{
    public class ValidationManager: IValidationService
    {
        public bool ValidationControl(Player player)
        {
            if (player.PlayerId>0 && player.PlayerName !="" && player.PlayerSurname !="" && player.NumberId !="" && player.DateofBirth !="")
            {
                Console.WriteLine("Check Successful");
                return true;
            }
            else
            {
                Console.WriteLine("Error!!! Check Failed");
                return false;
            }
        }

        public bool ValidationPromo(string promo, string newpromo = null)
        {
            if (promo!="" && newpromo=="")
            {
                Console.WriteLine("Promotion Check Successful");
                return true;
            }
            else if (newpromo != "" && promo != "")
            {
                Console.WriteLine("Promotion Check Successful");
                return true;
            }
            else
            {
                Console.WriteLine("Error!!! Check Failed");
                return false;
            }
        }
    }
}