using System.Reflection;

namespace RentAcar.DataContext.Entities
{
    public class Brand: BaseEntity
    {
        public string? Name { get; set; }
        List<Model> Models { get; set; } = [];
    }
}
