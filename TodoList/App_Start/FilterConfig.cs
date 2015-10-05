using System.Web;
using System.Web.Mvc;
using TodoList.Filters;

namespace TodoList
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new SecurityFilterAttribute());
        }
    }
}