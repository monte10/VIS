using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO.Tridy;
using ByznysVrstva;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private Vypis v = new Vypis();


        public ActionResult Index()
        {
            var tymy = v.StavSouteze();
            var kanada = v.Kanada();
            var goly = v.GolyTymy();
            var trestne = v.TabulkaTrestne();

            return View("Index", new IndexViewModel { Goly = goly, Kanada = kanada, Tresty = trestne, Tymy = tymy });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}