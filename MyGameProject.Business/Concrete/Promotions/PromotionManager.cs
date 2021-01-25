using System;
using MyGameProject.Business.Abstract;

namespace MyGameProject.Business.Concrete.Promotions
{
    public class PromotionManager : IPromotionService
    {
        private IValidationService _validationService;

        public PromotionManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public void AddPromotion(string promotionDetail)
        {
            bool control =_validationService.ValidationPromo(promotionDetail);
            if (control)
            {
                Console.WriteLine("Promotion Details : " + promotionDetail);
            }
            else
            {
                Console.WriteLine("Promotion Detail Failed");
            }
        }

        public void UpdatePromotion(string oldpromotionDetail, string newpromotionDetail)
        {
            bool control = _validationService.ValidationPromo(oldpromotionDetail,newpromotionDetail);
            if (control)
            {
                Console.WriteLine("New Promotion Updated Details : " + newpromotionDetail);
            }
            else
            {
                Console.WriteLine("Promotion Detail Failed");
            }
        }

        public void DeletePromotion(string promotionDetail)
        {
            bool control = _validationService.ValidationPromo(promotionDetail);
            if (control)
            {
                Console.WriteLine("Promotion Deleted Details : " + promotionDetail);
            }
            else
            {
                Console.WriteLine("Promotion Detail Failed");
            }
        }
    }
}