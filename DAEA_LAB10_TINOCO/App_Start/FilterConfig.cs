using System.Web;
using System.Web.Mvc;

namespace DAEA_LAB10_TINOCO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
