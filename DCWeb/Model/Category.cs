using System.ComponentModel.DataAnnotations;

namespace DCWeb.Model
{
    // 002 - Create Project DCWeb
    public class Category
    {
        [Key]
        public int Id { get; set; } // Id
        [Required]
        public string? Name { get; set; } // Name
        // 003 - Category
        [Display(Name = "Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only !")]
        public int DisplayOrder { get; set; } // DisplayOrder
    }
}
