using MyGameProject.Core.MyGameProject.DataAccess;
using MyGameProject.Entities.Concrete;

namespace MyGameProject.DataAccess.Abstract
{
    public interface IPlayerDal: IEntityRepository<Player>
    {
    }
}