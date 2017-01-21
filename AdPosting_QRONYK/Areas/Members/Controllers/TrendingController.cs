using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace AdPosting_QRONYK.Areas.Members.Controllers
{
    public class TrendingController : Controller
    {
        //
        // GET: /Members/Trending/

        BAL.Member.DALTrendingService service = new BAL.Member.DALTrendingService();
        public ActionResult Index()
        {
            List<TreadingMaster> model = new List<TreadingMaster>();
            model = (List<TreadingMaster>)service.getTrendings();
            return View(model);
        }

    }
}
