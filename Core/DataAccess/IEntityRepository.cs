using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{

    //Generic Constraint
    //class : Referans tip  +
    //IEntity : Ientity olabilir veya implemente eden bir nesne olabilir.
    //new() : Newlenebilir olmalı
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T,bool>> filter);  // tek data
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

      
    }
}

