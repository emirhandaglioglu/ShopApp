using ShopApp.BusinessLayer.Concrete;
using ShopApp.DataLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopApp.UI.Controllers
{
    public class MenuController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        [ChildActionOnly]
        public PartialViewResult MenuPartial()
        {
            var categoryList = cm.GetList();
            return PartialView("_MenuPartial", categoryList);
        }
    }
}