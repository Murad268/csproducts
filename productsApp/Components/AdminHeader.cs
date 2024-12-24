using Microsoft.AspNetCore.Mvc;

namespace productsApp.Components
{
    public class AdminHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
