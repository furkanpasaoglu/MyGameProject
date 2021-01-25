using System.Collections.Generic;

namespace MyGameProject.Core.MyGameProject.DataAccess
{
    public interface IEntityRepository<T>
    where T:class,new()
    {
        List<T> GetList(List<T> entity);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);

    }
}