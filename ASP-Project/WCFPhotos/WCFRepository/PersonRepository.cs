using System.Collections.Generic;
using System.Linq;
using WCFPhotos;

namespace WCFRepository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DbContextContainer dbContext;

        public PersonRepository()
        {
            dbContext = new DbContextContainer();
        }

        public List<Person> GetAll()
             => dbContext.People.ToList();

        public Person GetById(int id)
            => dbContext.People.Find(id);
    }
}
