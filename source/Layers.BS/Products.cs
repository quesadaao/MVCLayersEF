using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layers.DO.Interfases;
using ent = Layers.DO.Objects;
using data = Layers.DAL.Entidades;
using dal = Layers.DAL;
using AutoMapper;

namespace Layers.BS
{
    public class Products : ICRUD<ent.Products>
    {
        public void Delete(ent.Products t)
        {
            var _ent = Mapper.Map<ent.Products, data.Products>(t);
            new dal.Products().Delete(_ent);
        }

        public IEnumerable<ent.Products> GetAll()
        {
            var DetailsQuery = new dal.Products().GetAll();
            var Result = Mapper.Map<IEnumerable<data.Products>, IEnumerable<ent.Products>>(DetailsQuery);
            return Result;
        }

        public void Insert(ent.Products t)
        {
            var _ent = Mapper.Map<ent.Products, data.Products>(t);
            new dal.Products().Insert(_ent);

        }

        public void Update(ent.Products t)
        {
            var _ent = Mapper.Map<ent.Products, data.Products>(t);
            new dal.Products().Update(_ent);
        }
    }
}
