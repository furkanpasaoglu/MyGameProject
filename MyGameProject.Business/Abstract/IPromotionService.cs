namespace MyGameProject.Business.Abstract
{
    public interface IPromotionService
    {
        void AddPromotion(string promotionDetail);
        void UpdatePromotion(string oldpromotionDetail,string newpromotionDetail);
        void DeletePromotion(string promotionDetail);
    }
}