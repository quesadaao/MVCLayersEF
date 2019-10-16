using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ent = Layers.DO.Objects;

namespace Layers.Contracts
{
    [ServiceContract]
    public interface IProducts
    {
        [OperationContract]
        void Insert(ent.Products t);

        [OperationContract]
        void Update(ent.Products t);

        [OperationContract]
        void Delete(ent.Products t);

        [OperationContract]
        IEnumerable<ent.Products> GetAll();
    }
}
