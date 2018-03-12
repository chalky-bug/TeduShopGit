using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    interface IRepository<T> where T : class
    {
        // marks an entity as new
        void Add(T entity);

        //marks an entity as modified
        void Update(T entity);

        //marks an entity to be removed
        void Delete(T entity);

        //Delete multi records
        void DeteleMultil(Expression<Func<T, bool>> where);

        // get an entity by int id
        T GetSingleById(int id);














    }
}
