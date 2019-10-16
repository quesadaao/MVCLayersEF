using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.DO.Interfases
{
    public interface ICRUD<T>
    {
        void Insert(T t);
        IEnumerable<T> GetAll();
        void Delete(T t);
        void Update(T t);
    }
}
