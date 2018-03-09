using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Recruit.Models;

namespace Recruit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (var db = new Models.RecruitDBContext())
            {
                ViewBag.specializations = db.Specialization.ToList();
                ViewBag.careerLevels = db.CareerLevel.ToList();
            }

            return View();
        }
    }
}
