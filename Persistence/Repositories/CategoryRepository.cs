using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Supermarket.Domain.Models;
using Supermarket.Domain.Repositories;
using Supermarket.Persistence.Provider;

namespace Supermarket.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDatabaseProvider _provider;
        public CategoryRepository(IDatabaseProvider provider)
        {
            _provider = provider;
        }

        public async Task AddAsync(Category category)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Category> FindByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            using var conn = _provider.GetDbConnection();
            await conn.OpenAsync();

            return await conn.QueryAsync<Category>("");
        }

        public async void Remove(Category category)
        {
            throw new System.NotImplementedException();
        }

        public async void Update(Category category)
        {
            throw new System.NotImplementedException();
        }
    }
}