using Layers.DAL.Modelo;
using Layers.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using dato = Layers.DAL.Entidades;

namespace Layers.DAL
{
    public class Suppliers
    {
        private Repository<dato.Suppliers> _repository = new Repository<dato.Suppliers>(new NorthwindEntities());

        public void Insert(dato.Suppliers entidad)
        {
            _repository.Insert(entidad);
            _repository.Commit();
        }

        public void Update(dato.Suppliers entidad)
        {
            _repository.Update(entidad);
            _repository.Commit();
        }

        public void Delete(dato.Suppliers entidad)
        {
            _repository.Delete(entidad);
            _repository.Commit();
        }

        public IEnumerable<dato.Suppliers> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public dato.Suppliers GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public dato.Suppliers GetOne(Expression<Func<dato.Suppliers, bool>> predicado)
        {
            return _repository.GetOne(predicado);
        }
    }
}
