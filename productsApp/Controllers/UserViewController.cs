using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using productsApp.Repositories;

namespace productsApp.Controllers
{
    public class UserViewController : Controller
    {
        public IActionResult Index(int? categoryId)
        {
            var products = ProductRepository.getProducts();

            if (categoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value).ToList();
            }

            var categories = CategoryRepository.GetCategories();
            ViewBag.CategoryList = categories;

            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = ProductRepository.getProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
