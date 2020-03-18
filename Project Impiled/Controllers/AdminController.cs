using Project_Impiled.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Impiled.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [OutputCache(NoStore = true, Duration = 1)]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(Project_Impiled.Models.adminLogin loginmodel)
        {
            using (ImpiledEntities1 db = new ImpiledEntities1())
            {
                var ifvalid = db.adminLogins.Where(x => x.admin_username == loginmodel.admin_username && x.admin_password == loginmodel.admin_password).FirstOrDefault();
                if (ifvalid == null)
                {
                    loginmodel.ErrLog = "Wrong Password or Username";
                    return View("Login", loginmodel);
                }

                else
                {
                    Session["adminId"] = loginmodel.admin_id;
                    Session["username"] = loginmodel.admin_username;
                    return RedirectToAction("AllAnnouncement", "Dashboard");
                }
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login","Admin");
        }

    }
}