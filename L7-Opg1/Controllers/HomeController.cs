using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckboxHelpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public String Postback(FormCollection formCollection)
        {
            String str = "";
            if (formCollection["check1"].Contains("true"))
                str += "Check1 Checked ";

            if (formCollection["check2"].Contains("true"))
                str += "Check2 Checked ";

            if (formCollection["check3"].Contains("true"))
                str += "Check3 Checked ";

            if (str == "") 
                return "No one checked";
            else
                return str;
        }
        [HttpPost]
        public String Postback2(FormCollection formCollection)
        {
            String retur = "";
            String choices = formCollection["Choices"];
            String[] separated = choices.Split(',');
            foreach (String s in separated)
            {
                if (s != "false")
                {
                    retur += s + " og ";
                }
            }

            if (separated.Contains("Choice1"))
            {
                retur += "Choice 1 checked";
            }
            return retur;
        }
    }
}