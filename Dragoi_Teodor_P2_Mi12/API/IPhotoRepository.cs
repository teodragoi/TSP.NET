using System.Collections.Generic;
using WCFPhotos;

namespace WCFRepository
{
    public interface IPhotoRepository
    {
        void Add(Photo photo);

        Photo GetById(int id);

        List<Photo> GetAll();

        void Update(Photo updateModel);

        void Delete(int id);

        void TagPerson(int photoId, Person person);
    }
}
