using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoList.Models;

namespace TodoList.Filters
{
    public class SecurityFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;

            if (controllerName != "Home" || actionName != "Login")
            {
                User user = (User)filterContext.HttpContext.Session["user"];

                if (user == null)
                    filterContext.Result = new RedirectResult("/Home/Login");
            }
        }
    }
}