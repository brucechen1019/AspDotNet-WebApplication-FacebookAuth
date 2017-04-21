using System.Web;
using System.Web.Mvc;

namespace AspDotNet_WebApplication_FacebookAuth
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
