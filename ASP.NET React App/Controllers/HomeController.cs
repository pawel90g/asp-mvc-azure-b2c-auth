﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_React_App.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}