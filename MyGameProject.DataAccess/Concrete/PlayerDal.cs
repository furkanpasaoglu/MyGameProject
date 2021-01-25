using MyGameProject.Core.MyGameProject.DataAccess;
using MyGameProject.DataAccess.Abstract;
using MyGameProject.Entities.Concrete;

namespace MyGameProject.DataAccess.Concrete
{
    public class PlayerDal:EntityRepositoryBase<Player>,IPlayerDal
    {
        
    }
}