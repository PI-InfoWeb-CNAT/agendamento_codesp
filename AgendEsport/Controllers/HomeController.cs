using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendEsport.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Site para agendamentos das quadras do IFRN-CNAT.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "4002-8922.";

            return View();
        }
    }
}