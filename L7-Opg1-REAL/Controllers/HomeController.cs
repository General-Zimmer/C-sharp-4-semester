using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L7_Opg1_REAL.Controllers
{
    public class HomeController : Controller
    {
        List<SelectListItem> list;
        public ActionResult Index(string Country)
        {
            if (Session["CountryList"] == null)
            {
                list = new List<SelectListItem>();
                list.Add(new SelectListItem { Text = "China", Value = "CN" });
                list.Add(new SelectListItem { Text = "Denmark", Value = "DK", Selected = true });
                list.Add(new SelectListItem { Text = "USA", Value = "US" });
                list.Add(new SelectListItem { Text = "Germany", Value = "DE" });
                Session["CountryList"] = list;
            } else
            {
                list = (List<SelectListItem>)Session["CountryList"];
                list[1].Selected = true;
            }

            ViewBag.Country = list;
            ViewBag.CountryCode = Country;


            return View();
        }


    }
}