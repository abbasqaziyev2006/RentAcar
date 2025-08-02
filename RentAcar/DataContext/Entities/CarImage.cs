namespace RentAcar.DataContext.Entities
{
    public class CarImage: BaseEntity
    {
        public string? ImageUrl { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;
    }
}
