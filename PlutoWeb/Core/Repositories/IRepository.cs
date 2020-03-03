using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PlutoWeb.Core.Repositories
{
    /*
     *Below implementation is completely generic and has nothing 
     * do with our application called PlutoWeb. We can use it any 
     * application 
     */
    public interface IRepository<TEntity> where TEntity : class
    {
        //Will get objects 
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        // This method was not in the videos, but I thought it would be useful to add.
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        //Will add object or multiple objects
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        
        //Will remove a object or multiple objects 
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}