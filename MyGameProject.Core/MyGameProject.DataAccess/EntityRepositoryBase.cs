using System;
using System.Collections.Generic;
using MyGameProject.Core.MyGameProject.Entities;

namespace MyGameProject.Core.MyGameProject.DataAccess
{
    public class EntityRepositoryBase<TEntity>:IEntityRepository<TEntity>
    where TEntity:class,new()
    {
        public List<TEntity> GetList(List<TEntity> entity)
        {
            return entity;
        }

        public TEntity Add(TEntity entity)
        {
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            return entity;
        }
    }
}