namespace Supermarket.Domain.Models
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public short PackageQuantity { get; private set; }
        public EMeasureUnity MeasureUnity { get; private set; }

        public int CategoryId { get; private set; }
        public Category Category { get; private set; }
    }
}