using AdPosting_QRONYK.Areas.Members.Models.News;
using BAL.Member;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdPosting_QRONYK.Areas.Members.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /Members/News/
        BAL.Member.DALNewsService service = new BAL.Member.DALNewsService();
        public ActionResult Index()
        {
            List<NewsMaster> model = new List<NewsMaster>();
            model = (List<NewsMaster>)service.getNews();
            return View(model);
        }
        public ActionResult updateLike(int newsID, string likeunlike)
        {
            int result = service.updateLikes(newsID, likeunlike);
         return Json(new { status = "Success", message = "Success", like = result });
        }
        public ActionResult details(int id)
        {
            NewsMaster model = new NewsMaster();
            model = (NewsMaster)service.getNews(id);
            return View(model);
        }
        public ActionResult AddComments(int newsID, string Comment)
        {
            int result = service.AddComments(newsID, Comment, System.Web.HttpContext.Current.User.Identity.Name);
            return Json(new { status = "Success", message = "Success", like = result });
        }

    }
}
