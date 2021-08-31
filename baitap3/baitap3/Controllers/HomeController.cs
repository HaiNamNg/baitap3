using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap3.Models;

namespace baitap3.Controllers
{
    public class HomeController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        // GET: DeMo
        public ActionResult Index()

        {

            return View();

        }
        [HttpPost]
        public ActionResult GiaiPT(string SoA, string SoB)
        {
            double a = double.Parse(SoA);
            double b = double.Parse(SoB);
            double x = gpt.GiaiPT(a, b);
            ViewBag.NghiemPT = x;
            return View();
        }

    }
}