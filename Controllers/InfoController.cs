using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALR_02.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FAQs()
        {
            return View();
        }
        public ActionResult Reviews()
        {
            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            return View();
        }

    }
}