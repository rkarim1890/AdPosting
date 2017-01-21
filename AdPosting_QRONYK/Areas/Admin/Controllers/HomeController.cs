using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AdPosting_QRONYK.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Admin/Home/
        [Authorize(Roles = "Administrator")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginOut(string username)
        {



            System.Web.HttpContext.Current.Application.Remove(System.Web.HttpContext.Current.User.Identity.Name);

            Session.Abandon();
            Session.Clear();


            FormsAuthentication.SignOut();
            Session.Abandon(); // it will clear the session at the end of request
            return RedirectToAction("../Home");


        }

    }
}
