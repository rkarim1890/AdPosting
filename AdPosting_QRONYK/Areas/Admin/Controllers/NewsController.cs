using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdPosting_QRONYK.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /Admin/News/
       
        BAL.Member.DALNewsService service = new BAL.Member.DALNewsService();
        public ActionResult Index()
        {
            List<NewsMaster> model = new List<NewsMaster>();
            model = (List<NewsMaster>)service.getNews();
            return View(model);
        }

        public ActionResult AddNews()
        {
           NewsMaster model = new NewsMaster();
           
            return View(model);
        }

    }
}
