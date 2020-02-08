using System.Web;
using System.Web.Mvc;

namespace TI_PROJ_2257
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
