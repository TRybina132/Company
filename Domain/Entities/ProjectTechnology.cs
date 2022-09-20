namespace Domain.Entities
{
    public class ProductTechnology
    {
        public int TechnologyId { get; set; }
        public Technology? Technology { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
