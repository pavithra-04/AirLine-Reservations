using AirLine_ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALR_02.Controllers
{
    public class FlightsController : Controller
    {
        // GET: Flights
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Booking()
        {
            return View();
        }
        public ActionResult Payments()
        {
            return View();
        }
        public ActionResult Booking_Form()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Flights_Details(Flights objLoginModel)
        {

            if (ModelState.IsValid)
            {
                return View();
            }
            return View(objLoginModel);
        }

        public ActionResult Flights_Details()
        {
            Flights objFlights = new Flights();
            if (ModelState.IsValid)
            {
                return View();
            }
            return View(objFlights); 
        }




    }
}