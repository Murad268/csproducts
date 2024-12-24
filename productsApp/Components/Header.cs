using Microsoft.AspNetCore.Mvc;

namespace productsApp.Components
{
    public class Header : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
