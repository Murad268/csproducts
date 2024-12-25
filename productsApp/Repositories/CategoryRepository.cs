using System;
using System.Collections.Generic;
using productsApp.Models;

namespace productsApp.Repositories
{
    public class CategoryRepository
    {
        public static List<Category> categories = new List<Category>()
        {
            new Category {  Title = "Smartphones" },
            new Category {  Title = "Laptops" },
            new Category {  Title = "Gaming Consoles" },
            new Category {  Title = "Headphones" },
            new Category {  Title = "Accessories" }
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
