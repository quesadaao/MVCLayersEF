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
    public class Suppliers:ISuppliers
    {
        public void Delete(ent.Suppliers t)
        {
            new bs.Suppliers().Delete(t);
        }

        public IEnumerable<ent.Suppliers> GetAll()
        {
            return new bs.Suppliers().GetAll();
        }

        public void Insert(ent.Suppliers t)
        {
            new bs.Suppliers().Insert(t);
        }

        public void Update(ent.Suppliers t)
        {
            new bs.Suppliers().Update(t);
        }
    }
}
