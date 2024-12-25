using Microsoft.AspNetCore.Mvc;
using productsApp.Models;
using productsApp.Repositories;

namespace productsApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(ProductRepository.getProducts());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = CategoryRepository.GetCategories();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.Add(product);
                return RedirectToAction("Index");
            }

            ViewBag.Categories = CategoryRepository.GetCategories();
            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var product = ProductRepository.getProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            ViewBag.Categories = CategoryRepository.GetCategories();
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.Update(product);
                return RedirectToAction("Index");
            }

            ViewBag.Categories = CategoryRepository.GetCategories();
            return View(product);
        }


        public IActionResult Delete(int id)
        {
            ProductRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
