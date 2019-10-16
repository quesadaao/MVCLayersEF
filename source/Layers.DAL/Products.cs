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
    public class Products
    {
        private Repository<dato.Products> _repository = new Repository<dato.Products>(new NorthwindEntities());

        public void Insert(dato.Products entidad)
        {
            _repository.Insert(entidad);
            _repository.Commit();
        }

        public void Update(dato.Products entidad)
        {
            _repository.Update(entidad);
            _repository.Commit();
        }

        public void Delete(dato.Products entidad)
        {
            _repository.Delete(entidad);
            _repository.Commit();
        }

        public IEnumerable<dato.Products> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public dato.Products GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public dato.Products GetOne(Expression<Func<dato.Products, bool>> predicado)
        {
            return _repository.GetOne(predicado);
        }
    }
}
