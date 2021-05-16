using ShopApp.BusinessLayer.Concrete;
using ShopApp.DataLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopApp.UI.Controllers
{
    public class IstatistikController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        ProductManager pm = new ProductManager(new EFProductDAL());
        public ActionResult Index()
        {
            var catList = cm.GetList();
            ViewBag.CategoryListCount = catList.Count();

            var productList = pm.GetList();
            ViewBag.productListCount = productList.Where(x => x.CategoryId == 2).Count();


            var containA = pm.getContainsProduct("a");
            ViewBag.containA = containA;
            
            var query = productList.Join(catList,
                        urun => urun.CategoryId,
                        kategori => kategori.Id,
                        (product, category) => new { product, category })
                        .Select(result => new { ProductName = result.product, CategoryName = result.category.CategoryName })
                        .GroupBy(grup => grup.ProductName).FirstOrDefault();

            foreach (var item in query)
            {
                ViewBag.maxProductofCategory = item.CategoryName.ToString();
            }

            var IsActiveTrue = catList.Where(x => x.IsActive == true).Count();
            var IsActiveFalse = catList.Where(x => x.IsActive == false).Count();
            ViewBag.IsActive = IsActiveTrue - IsActiveFalse;

            return View();
        }
    }
}