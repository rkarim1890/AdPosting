using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace AdPosting_QRONYK.Areas.Members.Controllers
{
    public class LawsController : Controller
    {
        BAL.Member.DALLawsService service = new BAL.Member.DALLawsService();
        public ActionResult Index()
        {
            List<LawsMaster> model = new List<LawsMaster>();
            model = (List<LawsMaster>)service.getLaws();
            return View(model);
        }

    }
}
