using DCWeb.Data;
using DCWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DCWeb.Pages.Categories
{
    // 003 - Category
    public class IndexModel : PageModel
    {
        // Var
        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> Categories { get; set; }

        // ctor
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        // OnGet
        public void OnGet()
        {
            Categories = _db.Category;
        }
    }
}
