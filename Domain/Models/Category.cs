using System.Collections.Generic;

namespace Supermarket.Domain.Models
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<Product> Products { get; private set; }

    }
}