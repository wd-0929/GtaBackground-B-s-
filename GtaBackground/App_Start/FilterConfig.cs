using GtaBackground.Filters;
using System.Web;
using System.Web.Mvc;

namespace GtaBackground
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            GlobalFilters.Filters.Add(new CheckLogin(false));
        }
    }
}
