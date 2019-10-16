using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ent = Layers.DO.Objects;

namespace Layers.Contracts
{
    [ServiceContract]
    public interface ICategories
    {
        [OperationContract]
        void Insert(ent.Categories t);

        [OperationContract]
        void Update(ent.Categories t);

        [OperationContract]
        void Delete(ent.Categories t);

        [OperationContract]
        IEnumerable<ent.Categories> GetAll();
    }
}
