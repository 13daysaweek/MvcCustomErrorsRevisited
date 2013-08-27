using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThirteenDaysAWeek.MvcCustomErrorsRevisited.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //throw new NotImplementedException();
            return View();
        }

        public ActionResult Http500()
        {
            throw new NotImplementedException();
        }

        public ActionResult Http403()
        {
            return new HttpUnauthorizedResult();
        }

        public ActionResult Http404()
        {
            return new HttpNotFoundResult();
        }

        public ActionResult NotFound()
        {
            return View();
        }
    }
}
