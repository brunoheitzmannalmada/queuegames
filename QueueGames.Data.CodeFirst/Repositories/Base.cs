using QueueGames.Data.CodeFirst.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace QueueGames.Data.CodeFirst.Repositories
{
    public class Base<T> : IBase<T> where T : class
    {
        protected QueueGamesContext ContextEntities;

        public Base()
        {
            ContextEntities = new QueueGamesContext();
        }

        public T Insert(T entity)
        {
            ContextEntities.Set<T>().Add(entity);
            ContextEntities.SaveChanges();
            return entity;
        }

        public T Get(int id)
        {
            return ContextEntities.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return ContextEntities.Set<T>().ToList();
        }

        public T Update(T entity, int id)
        {
            if (entity == null) return null;

            var exists = ContextEntities.Set<T>().Find(id);
            if (exists != null)
            {
                ContextEntities.Entry(exists).CurrentValues.SetValues(entity);
                ContextEntities.SaveChanges();
            }

            return exists;
        }

        public void Delete(T entity)
        {
            ContextEntities.Set<T>().Remove(entity);
            ContextEntities.SaveChanges();
        }

        public void Delete(int id)
        {
            var exists = ContextEntities.Set<T>().Find(id);
            if (exists != null)
            {
                ContextEntities.Set<T>().Remove(exists);
                ContextEntities.SaveChanges();
            }
        }

        public T Find(Expression<Func<T, bool>> matchExpression)
        {
            return ContextEntities.Set<T>().SingleOrDefault(matchExpression);
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> matcExpression)
        {
            return ContextEntities.Set<T>().Where(matcExpression).ToList();
        }
    }
}
