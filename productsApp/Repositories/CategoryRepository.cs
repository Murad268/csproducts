using System;
using System.Collections.Generic;
using productsApp.Models;

namespace productsApp.Repositories
{
    public class CategoryRepository
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category { Id = 1, Title = "Smartphones" },
            new Category { Id = 2, Title = "Laptops" },
            new Category { Id = 3, Title = "Gaming Consoles" },
            new Category { Id = 4, Title = "Headphones" },
            new Category { Id = 5, Title = "Accessories" }
        };

        public static List<Category> GetCategories()
        {
            return categories;
        }

        public static Category GetCategoryById(int id)
        {
            return categories.Find(category => category.Id == id);
        }

        public static void Add(Category category)
        {
            int newId = categories.Count > 0 ? categories[^1].Id + 1 : 1;
            category.Id = newId;
            categories.Add(category);
        }

        public static void Update(Category updatedCategory)
        {
            Category category = categories.Find(c => c.Id == updatedCategory.Id);

            if (category != null)
            {
                category.Title = updatedCategory.Title;
            }
        }

        public static void Delete(int id)
        {
            Category category = categories.Find(c => c.Id == id);
            categories.Remove(category);
        }
    }
}
