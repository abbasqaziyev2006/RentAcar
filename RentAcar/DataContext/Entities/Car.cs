using System.Reflection;

namespace RentAcar.DataContext.Entities
{
    public class Car: BaseEntity
    {
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;

        public int ModelId { get; set; }
        public Model Model { get; set; } = null!;

        public int CategoryId { get; set; }
        public string? CarType { get; set; }

        public List<CarImage> CarImages { get; set; } = new();
    }
}
