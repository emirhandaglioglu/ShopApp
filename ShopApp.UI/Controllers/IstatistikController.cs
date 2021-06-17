using ShopApp.BusinessLayer.Concrete;
using ShopApp.DataLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopApp.UI.Controllers
{
    public class IstatistikController : BaseController
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        ProductManager pm = new ProductManager(new EFProductDAL());
        public ActionResult Index()
        {
            //Toplam kategori sayısı
            var catList = cm.GetList();
            ViewBag.CategoryListCount = catList.Count();

            //Ürümler tablosunda "Bilgisayar" kategorisine ait bilgisayar sayısı
            var productList = pm.GetList();
            ViewBag.productListCount = productList.Where(x => x.CategoryId == 2).Count();

            //Yazar adında 'a' harfi geçen yazar sayısı
            var containA = pm.getContainsProduct("a");
            ViewBag.containA = containA;

            //En fazla ürüne sahip kategori adı

            var maxProductofCategory = productList.GroupBy(x=>x.Category.CategoryName).FirstOrDefault();
            ViewBag.maxProductofCategory = maxProductofCategory.Key;

            //Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark
            var IsActiveTrue = catList.Where(x => x.IsActive == true).Count();
            var IsActiveFalse = catList.Where(x => x.IsActive == false).Count();
            ViewBag.IsActive = IsActiveTrue - IsActiveFalse;

            return View();
        }
    }
}