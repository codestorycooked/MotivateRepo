using MotivateMeAPI.DataAccess.Interface;
using MotivateMeAPI.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotivateMeAPI.DataAccess.Repository
{
    public class ThoughtsRepository : IThoughts
    {
        public Task Delete(string ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Thoughts>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Thoughts> GetByID(string Id)
        {
            throw new NotImplementedException();
        }

        public Task Post(Thoughts model)
        {
            throw new NotImplementedException();
        }

        public Task Put(string Id, Thoughts model)
        {
            throw new NotImplementedException();
        }
    }
}
