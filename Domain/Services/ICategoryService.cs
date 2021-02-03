using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.Domain.Models;

namespace Supermarket.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}