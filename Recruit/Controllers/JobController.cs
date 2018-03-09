using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recruit.Models;

namespace Recruit.Controllers
{
    public class JobController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

        public JsonResult Search()
        {
            var search_term = Request.QueryString["search"];
            var specialization = Request.QueryString["specialization"];
            var level = Request.QueryString["level"];

            var jobs = new List<Models.Job>();


            using( var db = new Models.RecruitDBContext() )
            {
                jobs = db.Job.Where(job => (job.title.Contains(search_term) || job.description.Contains(search_term)
                                            || job.requirements.Contains(search_term)
                                            || job.category.Contains(specialization)
                                            || job.level.Contains(level))).ToList();
            }

            return Json(new { status = "success", data = jobs }, JsonRequestBehavior.AllowGet);

        }
    }
}
