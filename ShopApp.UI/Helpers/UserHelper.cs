using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace ShopApp.UI.Helpers
{
    public class UserHelper
    {
        public static void AddUserInfo(UserInfo userInfo)
        {
            FormsAuthentication.SetAuthCookie(userInfo.Email, false);
            HttpContext.Current.Session["UserInfo"] = userInfo;
        }
        public static void RemoveUserInfo()
        {
            HttpContext.Current.Session["UserInfo"] = null;
        }
        public static UserInfo User => HttpContext.Current.Session["UserInfo"] as UserInfo;

    }
}