using Real_State_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_State_project.Controllers
{
    public class JuniorEngineersController : Controller
    {
        IAEntities1 db = new IAEntities1();
        // GET: JuniorEngineers
        public ActionResult Index()
        {
            return View();
        }
    }
}