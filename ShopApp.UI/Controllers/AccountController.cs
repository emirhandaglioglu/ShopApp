using ShopApp.BusinessLayer.Concrete;
using ShopApp.DataLayer.EntityFramework;
using ShopApp.Entity.Concrete;
using ShopApp.UI.Helpers;
using ShopApp.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopApp.UI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

        UserInfoManager um = new UserInfoManager(new EFUserInfoDAL());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            
            //if (!ModelState.IsValid)
            //    return View(model);

            var userInfoModel = new UserInfo()
            {
                Email = model.Email,
                UserName = model.UserName,
                Password = model.Password
            };
            var userInfo = um.Login(userInfoModel);
            if (userInfo != null)
            {
                UserHelper.AddUserInfo(userInfo);
                um.UserInfoUpdate(userInfo);
                if (userInfo.UserRoleId==1)
                    return RedirectToAction("Index", "Istatistik");
                else
                    return RedirectToAction("Index", "Home");
            }
            else
                ModelState.AddModelError("Login", "* The email or password is incorrect.");

            return View(model);
        }
    }
}