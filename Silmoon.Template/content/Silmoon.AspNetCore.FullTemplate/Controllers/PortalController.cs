﻿using Microsoft.AspNetCore.Mvc;

namespace Silmoon.AspNetCore.FullTemplate.Controllers
{
    public class PortalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Editor()
        {
            return View();
        }
        public IActionResult SignalR()
        {
            return View();
        }
    }
}
