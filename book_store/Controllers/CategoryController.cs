using book_store.Data;
using book_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace book_store.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BookStoreDBContext ctx;

        public CategoryController(BookStoreDBContext ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Index()
        {
            var categories = ctx.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View ();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid) 
            {
                ctx.Categories.Add(category);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
           
        }

        public IActionResult Edit(int id)
        {
            if (id == null || id == 0) 
            {
                return NotFound();
            }

            Category? category = ctx.Categories.Find(id);

            if(category == null) 
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid) 
            {
                ctx.Categories.Update(category);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? category = ctx.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult DeleteCategory(int? id)
        {
            Category? category = ctx.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            ctx.Categories.Remove(category);

            ctx.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
