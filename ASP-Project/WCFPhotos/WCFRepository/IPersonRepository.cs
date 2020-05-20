using System.Collections.Generic;
using WCFPhotos;

namespace WCFRepository
{
    public interface IPersonRepository
    {
        Person GetById(int id);

        List<Person> GetAll();
    }
}
