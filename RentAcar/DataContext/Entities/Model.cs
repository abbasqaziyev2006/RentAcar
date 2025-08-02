namespace RentAcar.DataContext.Entities
{
    public class Model:BaseEntity
    {
        public string? Name { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        List<Car> Cars { get; set; } = [];
    }
}
