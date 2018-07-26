using System.Web;
using System.Web.Mvc;

namespace WebApiApp_net452_cs_IndAuth_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
