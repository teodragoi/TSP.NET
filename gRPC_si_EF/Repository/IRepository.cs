using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T model);

        List<T> GetAll();

        T GetById(int id);
    }
}
