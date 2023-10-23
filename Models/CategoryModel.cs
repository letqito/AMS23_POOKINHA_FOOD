namespace AMS23_CAROUSEL.Models
{
    public class CategoryModel
    {
        public CategoryModel(string description)
        {
          Id = Guid.NewGuid();
          Description = description;
          IsActive = true;  
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public bool IsActive { get; set; }
        
    }
}