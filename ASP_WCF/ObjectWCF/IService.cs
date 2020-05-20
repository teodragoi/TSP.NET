using System.Collections.Generic;
using System.ServiceModel;

namespace ObjectWCF
{
    [ServiceContract]
    public interface IService<T> where T : class
    {
        [OperationContract]
        void Add(T model);

        [OperationContract]
        T GetById(int id);

        [OperationContract]
        List<T> GetAll();

        [OperationContract]
        void Update(T model);

        [OperationContract]
        void Delete(int id);
    }
}
