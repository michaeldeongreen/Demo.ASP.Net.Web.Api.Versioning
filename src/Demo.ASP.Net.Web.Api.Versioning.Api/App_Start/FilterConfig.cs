using System.Web;
using System.Web.Mvc;

namespace Demo.ASP.Net.Web.Api.Versioning.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
