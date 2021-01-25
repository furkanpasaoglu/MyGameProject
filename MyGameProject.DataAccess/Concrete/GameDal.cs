using System.Collections.Generic;
using MyGameProject.Core.MyGameProject.DataAccess;
using MyGameProject.DataAccess.Abstract;
using MyGameProject.Entities.Concrete;

namespace MyGameProject.DataAccess.Concrete
{
    public class GameDal : EntityRepositoryBase<Games>, IGameDal
    {
    }
}