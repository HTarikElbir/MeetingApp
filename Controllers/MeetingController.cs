﻿using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        //localhost/Meeting
        //localhost/Meeting/Index
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
