using productsApp.Repositories;

namespace productsApp.Utility
{
    public static class CategoryUtility
    {
        public static string GetCategoryName(int id)
        {
            var category = CategoryRepository.GetCategories().Find(c => c.Id == id);
            return category?.Title ?? "Təyin edilməyib";
        }
    }
}
