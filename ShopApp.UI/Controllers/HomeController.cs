using ShopApp.BusinessLayer.Concrete;
using ShopApp.DataLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopApp.UI.Controllers
{
    public class HomeController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductDAL());
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        public ActionResult Index()
        {
            var productList = pm.GetList();
            return View(productList);
        }

        public PartialViewResult CategoryPartial()
        {
            var categoryList = cm.GetList();
            return PartialView(categoryList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        

    }
}