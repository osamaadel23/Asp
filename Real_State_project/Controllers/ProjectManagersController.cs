using Real_State_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_State_project.Controllers
{
    public class ProjectManagersController : Controller
    {
        IAEntities1 db = new IAEntities1();
        // GET: ProjectManagers
        public ActionResult Index()
        {
            return View();
        }
    }
}