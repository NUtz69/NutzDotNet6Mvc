using System.ComponentModel.DataAnnotations;

namespace NutzWeb.Models
{
    // 000 - Create Project
    public class Category
    {
        [Key]
        public int Id { get; set; } // Id
        [Required]
        public string Name { get; set; } // Name
        public int DisplayOrder { get; set; } // DisplayOrder 
        public DateTime CreatedateTime { get; set; } = DateTime.Now; // CreatedateTime

    }
}
