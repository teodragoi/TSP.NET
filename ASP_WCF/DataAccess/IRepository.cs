using System.Collections.Generic;

namespace DataAccess
{
    public interface IRepository<T> where T : class
    {
        void Add(T model);

        T GetById(int id);

        List<T> GetAll();

        void Update(T model);

        void Delete(int id);
    }
}
