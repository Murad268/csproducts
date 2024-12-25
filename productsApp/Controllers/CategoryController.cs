using Microsoft.AspNetCore.Mvc;
using productsApp.Models;
using productsApp.Repositories;

namespace productsApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View(CategoryRepository.GetCategories());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoryRepository.Add(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Edit(int id)
        {
            var category = CategoryRepository.GetCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category updatedCategory)
        {
            if (ModelState.IsValid)
            {
                CategoryRepository.Update(updatedCategory);
                return RedirectToAction("Index");
            }
            return View(updatedCategory);
        }

        public IActionResult Delete(int id)
        {
            CategoryRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
