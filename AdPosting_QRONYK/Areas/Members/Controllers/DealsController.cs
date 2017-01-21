using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace AdPosting_QRONYK.Areas.Members.Controllers
{
    public class DealsController : Controller
    {
        BAL.Member.DALDealsService service = new BAL.Member.DALDealsService();

        // GET: /Members/Deals/

        public ActionResult Index()
        {
            List<DealsMaster> model = new List<DealsMaster>();
            model = (List<DealsMaster>)service.getDeals();
            return View(model);
        }
    }
}
