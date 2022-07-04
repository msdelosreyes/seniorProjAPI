using System.Web;
using System.Web.Mvc;

namespace PaymentAuthorizationWebAPI_CIS4290
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
