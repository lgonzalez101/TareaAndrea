using System.Web;
using System.Web.Mvc;

namespace TareaCrud_AndreaZuniga
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
