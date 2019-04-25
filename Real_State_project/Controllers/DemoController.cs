using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Real_State_project.Security;
using Real_State_project.Models;

namespace Real_State_project.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorize(Roles = "admin")]
        public ActionResult work1()
        {
            return View("work1");
        }

        [CustomAuthorize(Roles = "admin,pm")]
        public ActionResult work2()
        {
            return View("work2");
        }

        [CustomAuthorize(Roles = "admin,pm,customer")]
        public ActionResult work3()
        {
            return View("work3");
        }
    }
}