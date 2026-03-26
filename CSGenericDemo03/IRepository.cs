using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGenericDemo03
{
    public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
    }
}
