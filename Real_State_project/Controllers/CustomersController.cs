using Real_State_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_State_project.Controllers
{
    public class CustomersController : Controller
    {
        IAEntities1 db = new IAEntities1();
        // GET: Customers

        // /Customer/CustomerProfile
        public ActionResult CustomerProfile()
        {
            return View();
        }
    }
}