using System.Web;
using System.Web.Mvc;

namespace DotNetMeetupVS2017ShowCase
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
