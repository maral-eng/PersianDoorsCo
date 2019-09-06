﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineMarketPlace.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperVisor")]

    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InsertPost()
        {
            return View();
        }
    }
}