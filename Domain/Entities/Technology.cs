namespace Domain.Entities
{
    public class Technology
    {
        public int TechnologyId { get; set; }
        public string Name { get; set; }

        public ICollection<ProductTechnology>? ProjectTechnologies { get; set; }
    }
}
