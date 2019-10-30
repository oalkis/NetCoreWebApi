using DinamikCRM.DinamikCRM.Entity.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DinamikCRM.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Table { get; }
        IQueryable<T> TableNoTracking { get; }
        T GetById(object id);
        void Insert(T entity);
        void Insert(IEnumerable<T> entities);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        IEnumerable<T> GetSql(string sql);
    }
}
