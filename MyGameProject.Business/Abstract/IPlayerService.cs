using System.Collections.Generic;
using MyGameProject.Entities.Concrete;

namespace MyGameProject.Business.Abstract
{
    public interface IPlayerService
    {
        void GetList(Player player);
        void AddPlayer(Player player);
        void UpdatePlayer(Player player);
        void DeletePlayer(Player player);
    }
}