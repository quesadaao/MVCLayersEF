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
    public class Categories
    {
        private Repository<dato.Categories> _repository = new Repository<dato.Categories>(new NorthwindEntities());

        public void Insert(dato.Categories entidad)
        {
            _repository.Insert(entidad);
            _repository.Commit();
        }

        public void Update(dato.Categories entidad)
        {
            _repository.Update(entidad);
            _repository.Commit();
        }

        public void Delete(dato.Categories entidad)
        {
            _repository.Delete(entidad);
            _repository.Commit();
        }

        public IEnumerable<dato.Categories> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public dato.Categories GetOneById(int id)
        {
            return _repository.GetOneById(id);
        }

        public dato.Categories GetOne(Expression<Func<dato.Categories, bool>> predicado)
        {
            return _repository.GetOne(predicado);
        }
    }
}
