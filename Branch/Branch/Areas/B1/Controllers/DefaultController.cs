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
            List<int> gg = new List<int>();
            gg.Add(1);
            gg.Add(1);
            gg.Add(1);
            gg.Add(1);
            gg.Add(1);
            return View(gg);
        }
    }
}