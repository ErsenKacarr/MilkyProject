using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents._UILayoutViewComponents
{
    public class _FooterUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
