using Microsoft.AspNetCore.Mvc;
using productsApp.Repositories;

namespace productsApp.Controllers
{
    public class UserViewController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductRepository.getProducts();
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
