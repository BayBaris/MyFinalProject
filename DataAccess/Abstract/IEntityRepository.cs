using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Her Entity için ayrı ayrı Dal yazmak yerine genericler ile çalışabiliriz...
    //Generic Constraint --> Generic Kısıtlama...
    //class : referans tip | IEntity : IEntity veya IEntity implemente eden bir nesne olabilir...
    //new() : new'lenebilir olmalı...
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        //filter = null --> filtre vermeyebilirsin demek...
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        //refactoring...
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
