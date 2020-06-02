using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using WCFPhotos;

namespace WCFRepository
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly DbContextContainer dbContext;

        public PhotoRepository()
        {
            dbContext = new DbContextContainer();
        }

        public void Add(Photo photo)
        {
            dbContext.Photos.Add(photo);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var photo = dbContext.Photos.Find(id);
            dbContext.Photos.Remove(photo);
            dbContext.SaveChanges();
        }

        public List<Photo> GetAll()
            => dbContext.Photos.ToList();

        public Photo GetById(int id)
            => dbContext.Photos.Find(id);

        public void TagPerson(int photoId, Person person)
        {
            var photo = dbContext.Photos.Find(photoId);
            person.Photos.Add(photo);
            dbContext.SaveChanges();
        }

        public void Update(Photo updateModel)
        {
            var photo = dbContext.Photos.Find(updateModel.Id);
            if (photo != null)
            {
                photo = updateModel;
                dbContext.Photos.AddOrUpdate(photo);
                dbContext.SaveChanges();
            }
        }
    }
}
