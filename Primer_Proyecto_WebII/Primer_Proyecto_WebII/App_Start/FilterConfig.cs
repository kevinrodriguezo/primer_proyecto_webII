using System.Web;
using System.Web.Mvc;

namespace Primer_Proyecto_WebII
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
