using System.Collections.Generic;
using System.ServiceModel;
using WCFPhotos;

namespace WCFService
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        Person GetById(int id);

        [OperationContract]
        List<Person> GetAll();
    }
}
