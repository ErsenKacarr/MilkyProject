using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents._UILayoutViewComponents
{
    public class _FeatureUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
