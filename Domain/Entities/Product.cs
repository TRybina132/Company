namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Desciption { get; set; }
        public bool IsActive { get; set; }
        public DateTime OrientedDeadline { get; set; }
        public decimal Price { get; set; }
        
        public ICollection<ProductTechnology>? ProjectTechnologies { get; set; }
    }
}
