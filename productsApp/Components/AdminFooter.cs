using Microsoft.AspNetCore.Mvc;

namespace productsApp.Components
{
    public class AdminFooter : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
