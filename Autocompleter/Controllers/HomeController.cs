using Autocompleter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Autocompleter.Controllers
{
    public class HomeController : Controller
    {
        UserContext db = new UserContext();
        ClientsContext dbU = new ClientsContext();
        public int getUserId()
        {
            int userId = 0;
            foreach (var u in db.Users)
            {
                if (u.Email == User.Identity.Name)
                {
                    userId = u.Id;
                    break;
                }
            }
            return userId;
        }
        public int getUserRole()
        {
            int roleid = 0;
            foreach (var u in db.Users)
            {
                if (u.Email == User.Identity.Name)
                {
                    roleid = u.RoleId;
                    break;
                }
            }
            return roleid;
        }
        public ActionResult Index(string sortClient, string searchString)
        {
            ClientsContext db = new ClientsContext();
            ViewBag.roleid = getUserRole();//Добавить в каждый Action Result для админа

            ViewBag.NameSortParm = String.IsNullOrEmpty(sortClient) ? "Name desc" : "";
            var clients = from s in db.People
                          select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                clients = clients.Where(s => s.Namee.ToUpper().Contains(searchString.ToUpper())
                                       || s.TrueName.ToUpper().Contains(searchString.ToUpper()));
            }
            switch (sortClient)
            {
                case "Name desc":
                    clients = clients.OrderByDescending(s => s.Namee);
                    break;
                default:
                    clients = clients.OrderBy(s => s.Namee);
                    break;
            }


            ViewBag.client = clients;
            return View(clients.ToList());




        }


        [Authorize(Roles = "admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Admin()
        {
            ViewBag.roleid = getUserRole();
            ClientsContext db = new ClientsContext();
            var clients = from x in db.People
                          select x;
            ViewBag.client = db.People;
            return View(clients.ToList());


        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            return RedirectToAction("index", "Home");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(People people)
        {
            dbU.People.Add(people);
            dbU.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            ViewBag.roleid = getUserRole();

            People b = dbU.People.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            People b = dbU.People.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            dbU.People.Remove(b);
            dbU.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]

        public ActionResult Edit(int? id)
        {
            ViewBag.roleid = getUserRole();

            if (id == null)
            {
                return HttpNotFound();
            }
            People client = dbU.People.Find(id);
            if (client != null)
            {
                return View(client);
            }
            return HttpNotFound();
        }
        [HttpPost]

        public ActionResult Edit(People client)
        {
            db.Entry(client).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}