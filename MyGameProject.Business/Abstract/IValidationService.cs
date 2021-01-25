using MyGameProject.Entities.Concrete;

namespace MyGameProject.Business.Abstract
{
    public interface IValidationService
    {
        bool ValidationControl(Player player);
        bool ValidationPromo(string promo, string newpromo = null);
    }
}