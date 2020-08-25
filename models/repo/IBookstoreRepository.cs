using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.models.repo
{
    interface IBookstoreRepository<TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
