using System.Web;
using System.Web.Mvc;

namespace AdPosting_QRONYK
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}