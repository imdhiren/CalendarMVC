using CalendarMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalendarMVC.Controllers
{
    public class HomeController : Controller
    {
        #region Action Method

        /// <summary>
        /// Home index method
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var model = Calendar.Gets(DateTime.Now.Month, DateTime.Now.Year);
            return View(model);
        }
        #endregion

        #region Partial View

        /// <summary>
        /// Return calendar partial view
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public ActionResult UpdateCalendar(int month, int year)
        {
            var model = Calendar.Gets(month, year);
            return PartialView("_CalendarPartial", model);
        }

        #endregion
    }
}