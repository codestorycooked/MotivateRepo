using MotivateMeAPI.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MotivateMeAPI.DataAccess.Models;
using Microsoft.Extensions.Options;
using MotivateMeAPI.Providers;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver;

namespace MotivateMeAPI.DataAccess.Repository
{
    public class CategoryRepository : ICategory

    {
        private MotivateContext context = null;
        public CategoryRepository(IOptions<Settings> settings)
        {
            context = new MotivateContext(settings);
        }


        public async Task<IEnumerable<Categories>> GetAll()
        {
            return await context.Categories.Find(_ => true).ToListAsync();
        }

        public async Task<Categories> GetByID(string Id)
        {
            var filter = Builders<Categories>.Filter.Eq("Id", Id);
            return await context.Categories
                                 .Find(filter)
                                 .FirstOrDefaultAsync();
        }

        public async Task Post(Categories model)
        {
            await context.Categories.InsertOneAsync(model);
        }

        public async Task Put(string Id, Categories model)
        {
            var filter = Builders<Categories>.Filter.Eq(s => s.Id, Id);
            var update = Builders<Categories>.Update
                                .Set(s => s.CategoryName, model.CategoryName)
                                .Set(s => s.CategoryPicture, model.CategoryPicture)
                                .Set(s => s.CategoryDescription, model.CategoryDescription)
                                .Set(s => s.DateCreated, DateTime.Now);
            await context.Categories.UpdateOneAsync(filter, update);
        }

        public async Task Delete(string ID)
        {
            await context.Categories.DeleteOneAsync(Builders<Categories>.Filter.Eq("Id", ID));
        }
    }
}
