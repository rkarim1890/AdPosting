using System.Web.Mvc;

namespace AdPosting_QRONYK.Areas.Members
{
    public class MembersAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Members";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Members_default",
                "Members/{controller}/{action}/{id}",
               new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                  new string[] { "AdPosting_QRONYK.Areas.Members.Controllers" }
            );
        }
    }
}
