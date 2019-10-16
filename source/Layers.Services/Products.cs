using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ent = Layers.DO.Objects;
using dal = Layers.DAL;
using bs = Layers.BS;
using Layers.Contracts;

namespace Layers.Services
{
    public class Products:IProducts
    {
        public void Delete(ent.Products t)
        {
            new bs.Products().Delete(t);
        }

        public IEnumerable<ent.Products> GetAll()
        {
            return new bs.Products().GetAll();
        }

        public void Insert(ent.Products t)
        {
            new bs.Products().Insert(t);
        }

        public void Update(ent.Products t)
        {
            new bs.Products().Update(t);
        }
    }
}
