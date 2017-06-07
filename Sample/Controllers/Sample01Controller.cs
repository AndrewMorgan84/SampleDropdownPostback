using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Controllers
{
    public class Sample01Controller : Controller
    {
        // GET: Sample01
        public ActionResult Index()
        {
            var m = new Sample01ViewModel();
            return View(m);
        }

        // POST: sample01
        [HttpPost]
        public ActionResult Index(string dummy)
        {
            var m = new Sample01ViewModel();
            m.SelectedCountry = Request["ddlCountries"];
            return View(m);
        }
    }
}