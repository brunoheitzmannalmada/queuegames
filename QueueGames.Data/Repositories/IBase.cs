using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueGames.Data.Repositories
{
    public interface IBase<T>
    {
        T Insert(T entity);
        T Get(int id);
        T Update(T entity, int id);
        void Delete(T entity);
        IEnumerable<T> GetAll();
    }
}
