using System.Web;
using System.Web.Mvc;

namespace N5_NongSan_SENHOALUA
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
