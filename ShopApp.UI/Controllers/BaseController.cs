using ShopApp.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopApp.UI.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["UserInfo"] == null)
            {
                filterContext.Result = RedirectToAction("Login", "Account");
                return;
            }
            else
                base.OnActionExecuting(filterContext);
        }
    }
}