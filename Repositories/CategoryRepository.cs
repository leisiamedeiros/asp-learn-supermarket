using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.Domain.Models;
using Supermarket.Domain.Repositories;

namespace Supermarket.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task AddAsync(Category category)
        {
            throw new System.NotImplementedException();
        }

        public Task<Category> FindByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Category>> ListAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Category category)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new System.NotImplementedException();
        }
    }
}