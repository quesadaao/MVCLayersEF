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
    public class Categories : ICRUD<ent.Categories>
    {
        public void Delete(ent.Categories t)
        {
            var _ent = Mapper.Map<ent.Categories, data.Categories>(t);
            new dal.Categories().Delete(_ent);
        }

        public IEnumerable<ent.Categories> GetAll()
        {
            var DetailsQuery = new dal.Categories().GetAll();
            var Result = Mapper.Map<IEnumerable<data.Categories>, IEnumerable<ent.Categories>>(DetailsQuery);
            return Result;
        }

        public void Insert(ent.Categories t)
        {
            var _ent = Mapper.Map<ent.Categories, data.Categories>(t);
            new dal.Categories().Insert(_ent);

        }

        public void Update(ent.Categories t)
        {
            var _ent = Mapper.Map<ent.Categories, data.Categories>(t);
            new dal.Categories().Update(_ent);
        }
    }
}
