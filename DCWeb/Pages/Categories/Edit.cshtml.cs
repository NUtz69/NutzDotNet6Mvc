using DCWeb.Data;
using DCWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DCWeb.Pages.Categories
{
    // 003 - Category
    public class EditModel : PageModel
    {
        // Var
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }

        // ctor
        public EditModel(ApplicationDbContext db)
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
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Category.Name", "The DisplayOder cannot exactly match the name !");
            }

            if (ModelState.IsValid)
            {
                // Data
                _db.Category.Update(Category);
                await _db.SaveChangesAsync();
                // TempData
                TempData["success"] = "Category updated successfully";

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
