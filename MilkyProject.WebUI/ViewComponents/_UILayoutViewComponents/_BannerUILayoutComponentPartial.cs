﻿using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents._UILayoutViewComponents
{
    public class _BannerUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
