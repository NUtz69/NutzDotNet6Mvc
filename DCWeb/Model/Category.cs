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
        public int DisplayOrder { get; set; } // DisplayOrder
    }
}
