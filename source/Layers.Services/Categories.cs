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
    public class Categories : ICategories
    {
        public void Delete(ent.Categories t)
        {
            new bs.Categories().Delete(t);
        }

        public IEnumerable<ent.Categories> GetAll()
        {
            return new bs.Categories().GetAll();
        }

        public void Insert(ent.Categories t)
        {
            new bs.Categories().Insert(t);
        }

        public void Update(ent.Categories t)
        {
            new bs.Categories().Update(t);
        }
    }
}
