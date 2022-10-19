using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace MVCASFIES.ActionFilter
{
    public class SessionValidatorAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (HttpContext.Current.Session["admin"] == null)
            {
                filterContext.Result = new RedirectResult("~/Administrador/Login");
            }
            base.OnActionExecuted(filterContext);
        }
    }
}