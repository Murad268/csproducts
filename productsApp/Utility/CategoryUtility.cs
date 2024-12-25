using productsApp.Repositories;

namespace productsApp.Utility
{
    public class CategoryUtility
    {
        public static string GetCategoryName(int id)
        {
            return CategoryRepository.GetCategories().Find(category => category.Id == id).Title;
        }
    }
}
