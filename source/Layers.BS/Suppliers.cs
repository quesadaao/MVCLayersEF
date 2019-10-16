using Layers.DO.Interfases;
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
    public class Suppliers : ICRUD<ent.Suppliers>
    {
        public void Delete(ent.Suppliers t)
        {
            var _ent = Mapper.Map<ent.Suppliers, data.Suppliers>(t);
            new dal.Suppliers().Delete(_ent);
        }

        public IEnumerable<ent.Suppliers> GetAll()
        {
            var DetailsQuery = new dal.Suppliers().GetAll();
            var Result = Mapper.Map<IEnumerable<data.Suppliers>, IEnumerable<ent.Suppliers>>(DetailsQuery);
            return Result;
        }

        public void Insert(ent.Suppliers t)
        {
            var _ent = Mapper.Map<ent.Suppliers, data.Suppliers>(t);
            new dal.Suppliers().Insert(_ent);

        }

        public void Update(ent.Suppliers t)
        {
            var _ent = Mapper.Map<ent.Suppliers, data.Suppliers>(t);
            new dal.Suppliers().Update(_ent);
        }
    }
}
