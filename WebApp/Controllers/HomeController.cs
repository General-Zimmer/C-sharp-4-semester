using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL2;
using DTO2.models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.biller = BLL.GetBiller();
            List<Bill> biller = BLL.GetBiller();
            foreach (Bill bil in biller)
            {
                Debug.Print(bil.Name);
            }
            Debug.Print("Slut");

            return View();
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