namespace NutzWeb.Models
{
    // 000 - Create Project
    public class Category
    {
        public int Id { get; set; } // Id
        public string Name { get; set; } // Name
        public int DisplayOrder { get; set; } // DisplayOrder 
        public DateTime CreatedateTime { get; set; } = DateTime.Now; // CreatedateTime

    }
}
