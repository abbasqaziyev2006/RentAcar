namespace RentAcar.DataContext.Entities
{
    public class CarType: BaseEntity
    {
        public string? Name { get; set; }
        List<Model> Models { get; set; } = [];
    }
}
