using DCWeb.Data;
using DCWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DCWeb.Pages.Categories
{
    // 003 - Category
    public class CreateModel : PageModel
    {
        // Var
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }

        // ctor
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        // OnGet
        public void OnGet()
        {
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
                await _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();
                // TempData
                TempData["success"] = "Category created successfully";

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
