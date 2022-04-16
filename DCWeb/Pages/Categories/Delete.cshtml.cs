using DCWeb.Data;
using DCWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DCWeb.Pages.Categories
{
    // 003 - Category
    public class DeleteModel : PageModel
    {
        // Var
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }

        // ctor
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        // OnGet
        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
            //Category = _db.Category.FirstOrDefault(c => c.Id == id);
            //Category = _db.Category.SingleOrDefault(c => c.Id == id);
            //Category = _db.Category.Where(c => c.Id == id).FirstOrDefault();
        }

        // OnPost
        public async Task<IActionResult> OnPost()
        {
            // Var
            var categoryFromDb = _db.Category.Find(Category.Id);

            // Delete
            if (categoryFromDb != null)
            {
                _db.Category.Remove(categoryFromDb);
                await _db.SaveChangesAsync();
                // TempData
                TempData["success"] = "Category deleted successfully";

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
