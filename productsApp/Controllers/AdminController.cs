using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using productsApp.Models;
using productsApp.Repositories;
using System.IO;

namespace productsApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdminController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View(ProductRepository.getProducts());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product, IFormFile imageFile)
        {
            ModelState.Remove("Image");
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            if (imageFile != null && imageFile.Length > 0)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(fileStream);
                }

                product.Image = "/images/" + uniqueFileName;
            }
            else
            {
                product.Image = "/images/default.jpg";
            }

            ProductRepository.Add(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(ProductRepository.getProductById(id));
        }

        [HttpPost]
        public IActionResult Edit(Product product, IFormFile imageFile)
        {
            var existingProduct = ProductRepository.getProductById(product.Id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            if (imageFile != null && imageFile.Length > 0)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(fileStream);
                }

                product.Image = "/images/" + uniqueFileName;
            }
            else
            {
                product.Image = existingProduct.Image;
            }

            ProductRepository.Update(product);
            return RedirectToAction("Index");
        }

        public IActionResult Destroy(int id)
        {
            ProductRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
