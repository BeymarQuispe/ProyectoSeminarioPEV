using System.Web;
using System.Web.Mvc;

namespace PLATAFORMA_VIRTUAL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}