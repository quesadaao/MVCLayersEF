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
    public interface ISuppliers
    {
        [OperationContract]
        void Insert(ent.Suppliers t);

        [OperationContract]
        void Update(ent.Suppliers t);

        [OperationContract]
        void Delete(ent.Suppliers t);

        [OperationContract]
        IEnumerable<ent.Suppliers> GetAll();
    }
}
