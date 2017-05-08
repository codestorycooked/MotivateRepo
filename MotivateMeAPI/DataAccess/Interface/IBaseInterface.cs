using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotivateMeAPI.DataAccess.Interface
{
    public interface IBaseInterface<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(string Id);
        Task Put(string Id, T model);
        Task Post(T model);
        Task Delete(string ID);

    }
}
