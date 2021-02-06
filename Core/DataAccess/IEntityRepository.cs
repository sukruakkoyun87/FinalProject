using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;


namespace Core.DataAccess
{
    // Generic Constraint
    // class : Referans Tip Olabilir
    // IEntity : IEntity olanbilir veya IEntity implemente eden bir nesne olabilir
    // new(): new'lanabilir olmalı
    public interface IEntityRepository<T> where T:class ,IEntity ,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
