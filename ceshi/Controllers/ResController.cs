using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ceshi.Controllers
{
    public class ResController : Controller
    {
        // GET: Res
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddMenu()
        {
            return View();
        }
    }
}