using System.Web;
using System.Web.Mvc;
using WebApi.Utility.Filter;

namespace WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute()); 
        }
    }
}
