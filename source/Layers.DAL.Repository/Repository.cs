using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dBContext;

        public Repository(DbContext context)
        {
            _dBContext = context;
        }

        public IQueryable<T> AsQueryable()
        {
            return _dBContext.Set<T>().AsQueryable();
        }

        public void Commit()
        {
            _dBContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (_dBContext.Entry<T>(entity).State == EntityState.Detached)
            {
                _dBContext.Set<T>().Add(entity);
            }
            _dBContext.Entry<T>(entity).State = EntityState.Deleted;
        }

        public void Dispose()
        {
            return;
        }

        public IEnumerable<T> GetAll()
        {
            return _dBContext.Set<T>();
        }

        public T GetOne(System.Linq.Expressions.Expression<Func<T, bool>> predicado)
        {
            return _dBContext.Set<T>().Where(predicado).FirstOrDefault();
        }

        public T GetOneById(int id)
        {
            return _dBContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            if (_dBContext.Entry<T>(entity).State != EntityState.Detached)
            {
                _dBContext.Entry<T>(entity).State = EntityState.Added;
            }
            else
            {
                _dBContext.Set<T>().Add(entity);
            }
        }

        public IEnumerable<T> Search(System.Linq.Expressions.Expression<Func<T, bool>> predicado)
        {
            return _dBContext.Set<T>().Where(predicado);
        }

        public void Update(T entity)
        {
            if (_dBContext.Entry<T>(entity).State == EntityState.Detached)
            {
                _dBContext.Set<T>().Attach(entity);
            }
            _dBContext.Entry<T>(entity).State = EntityState.Modified;
        }

        //public void Dispose() {
        //    return;
        //}

      
    }
}
