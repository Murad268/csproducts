using Microsoft.AspNetCore.Mvc;

namespace productsApp.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
