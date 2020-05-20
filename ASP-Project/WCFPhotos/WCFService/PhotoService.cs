using System;
using System.Collections.Generic;
using WCFPhotos;
using WCFRepository;

namespace WCFService
{
    public class PhotoService : IPhotoService
    {

        private readonly IPhotoRepository photoRepository;

        public PhotoService()
        {
            photoRepository = new PhotoRepository();
        }
        
        public void Add(Photo photo)
        {
            photoRepository.Add(photo);
        }

        public void Delete(int id)
        {
            photoRepository.Delete(id);
        }

        public List<Photo> GetAll()
            => photoRepository.GetAll();

        public Photo GetById(int id)
            => photoRepository.GetById(id);

        public void TagPerson(int photoId, Person person)
        {
            photoRepository.TagPerson(photoId, person);
        }

        public void Update(Photo updateModel)
        {
            photoRepository.Update(updateModel);
        }
    }
}
