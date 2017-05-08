using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostOffice.Domain.Repos
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetPage(GetPageRequest request);
        T GetById(int id);
        bool Remove(int id);
        T Add(T entity);
        T Update(T entity);
    }
}