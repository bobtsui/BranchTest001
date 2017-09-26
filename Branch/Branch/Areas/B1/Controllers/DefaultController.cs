using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Branch.Areas.B1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: B1/Default
        public ActionResult Index()
        {
            int a = 0;
            return View(a);
        }
    }
}