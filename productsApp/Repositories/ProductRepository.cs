using System;
using System.Collections.Generic;
using productsApp.Models;

namespace productsApp.Repositories
{
    public class ProductRepository
    {
        public static List<Product> products = new List<Product>()
        {
            new Product {  Name = "Samsung Galaxy S22", Price = 849.99m, Count = 70, Description = "A powerful Android smartphone with top-tier performance and design.", CategoryId = 1 },
            new Product {   Name = "Sony WH-1000XM4 Headphones", Price = 349.99m, Count = 30, Description = "Noise-canceling headphones with exceptional sound quality and comfort.", CategoryId = 4 },
            new Product { Name = "Dell XPS 13 Laptop", Price = 1199.99m, Count = 25, Description = "A sleek and lightweight laptop with top-notch performance for professionals.", CategoryId = 2 },
            new Product {   Name = "Apple iPad Pro 12.9", Price = 1099.99m, Count = 40, Description = "A high-performance tablet designed for creative professionals and multitasking.", CategoryId = 2 },
            new Product {   Name = "Sony PlayStation 5", Price = 499.99m, Count = 15, Description = "Next-generation gaming console with 4K gaming and immersive experiences.", CategoryId = 3 },
            new Product {  Name = "GoPro HERO 11", Price = 399.99m, Count = 60, Description = "High-resolution action camera for adventure enthusiasts and vloggers.", CategoryId = 5 },
            new Product {  Name = "Logitech MX Master 3", Price = 99.99m, Count = 80, Description = "Advanced wireless mouse for productivity and ergonomic comfort.", CategoryId = 5 },
            new Product {  Name = "Philips Hue Smart Bulb", Price = 49.99m, Count = 120, Description = "Smart lighting solution with customizable colors and app control.", CategoryId = 5 },
            new Product {  Name = "Fitbit Charge 5", Price = 129.99m, Count = 100, Description = "Advanced fitness tracker with heart rate monitoring and sleep tracking.", CategoryId = 5 }
        };

        public static List<Product> getProducts()
        {
            return products;
        }

        public static Product getProductById(int id)
        {
            return products.Find(product => product.Id == id);
        }

        public static void Add(Product product)
        {
         
            products.Add(product);

            Console.WriteLine($"Product added with ID: {product.Id}, Name: {product.Name}");
        }

        public static void Update(Product updatedProduct)
        {
            Product product = products.Find(product => product.Id == updatedProduct.Id);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Price = updatedProduct.Price;
                product.Count = updatedProduct.Count;
                product.Description = updatedProduct.Description;
                product.CategoryId = updatedProduct.CategoryId; // Yeni sahəni yeniləmək
            }
        }

        public static void Delete(int id)
        {
            Product product = products.Find(product => product.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
        }


   
    }
}
