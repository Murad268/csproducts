using Microsoft.AspNetCore.Mvc;

namespace productsApp.Components
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
