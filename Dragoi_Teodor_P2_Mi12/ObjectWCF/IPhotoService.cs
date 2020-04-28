
using System.Collections.Generic;
using System.ServiceModel;
using WCFPhotos;

namespace WCFService
{
    [ServiceContract]
    public interface IPhotoService
    {
        [OperationContract]
        void Add(Photo photo);

        [OperationContract]
        void Update(Photo updateModel);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        Photo GetById(int id);

        [OperationContract]
        List<Photo> GetAll();

        [OperationContract]
        void TagPerson(int photoId, Person person);
    }
}
