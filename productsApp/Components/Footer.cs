using Microsoft.AspNetCore.Mvc;

namespace productsApp.Components11
{
    public class Footer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
