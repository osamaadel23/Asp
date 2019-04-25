using Real_State_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Real_State_project.Controllers
{
    public class AdminController : Controller
    {
        // test mna4 da3wa beeh ////////////
        IAEntities1 db = new IAEntities1();
        // GET: Admin

        public ActionResult list()
        {
            var users = db.users.ToList();
            return View(users);
        }

        public ActionResult listCT()
        {
            var users = db.users.ToList();
            return View(users);
        }

        public ActionResult listPM()
        {
            var users = db.users.ToList();
            return View(users);
        }

        public ActionResult listTL()
        {
            var users = db.users.ToList();
            return View(users);
        }

        public ActionResult listJE()
        {
            var users = db.users.ToList();
            return View(users);
        }

        // /Admin/AddUser
        [HttpGet]
        public ActionResult AddUser()
        {
           
            users user = new users();
            //user = db.UserRole.Where(c => c.Id != 1).ToList();
            return View(user);
        }

        [HttpPost]
        public ActionResult AddUser(users user)
        {
            db.users.Add(user);
            db.SaveChanges();
            return RedirectToAction("list");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user =db.users.SingleOrDefault(c => c.Id == id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(int id ,string email ,string firstname ,string lastname ,string phone ,string jobDescription)
        {
            var user = db.users.SingleOrDefault(c => c.Id == id);
            user.lastname = lastname;
            user.firstname = firstname;
            user.email = email;
            user.phone = phone;
            user.jobDescription = jobDescription;
            db.SaveChanges();
            return RedirectToAction("list");
        }

        public ActionResult delete(int id)
        {

            var user = db.users.SingleOrDefault(c => c.Id== id);
            var deluser = db.users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("list");
        }




        //../////////////////////////////

        // /Admin/AdminProfile
        public ActionResult AdminProfile()
        {
            return View();
        }

        // /Admin/add
        public ActionResult add()
        {
            return View();
        }

    }
}