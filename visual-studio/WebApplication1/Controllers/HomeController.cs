﻿using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return File("~/app/index.html", "text/html");
        }
    }
}