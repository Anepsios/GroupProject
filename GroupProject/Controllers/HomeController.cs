﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupProject.Controllers
{
    public class HomeController : Controller
    {
        //
        //GET:  /Home/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}