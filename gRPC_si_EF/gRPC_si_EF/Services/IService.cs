using System.Collections.Generic;

namespace gRPC_si_EF.Services
{
    public interface IService<T> where T : class
    {
        void Add(T model);

        List<T> GetAll();

        T GetById(int id);
    }
}
