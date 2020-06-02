using System.Collections.Generic;
using WCFPhotos;
using WCFRepository;

namespace WCFService
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService()
        {
            personRepository = new PersonRepository();
        }

        public List<Person> GetAll()
            => personRepository.GetAll();

        public Person GetById(int id)
            => personRepository.GetById(id);
    }
}
