using FluentValidation.Results;
using ShopApp.BusinessLayer.Concrete;
using ShopApp.BusinessLayer.ValidationRules;
using ShopApp.DataLayer.EntityFramework;
using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopApp.UI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductDAL());
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        // GET: Product
        [Authorize]
        public ActionResult Index()
        {
            var productList = pm.GetList();
            return View(productList);
        }
       
        public ActionResult Detail(int id)
        {
            var product = pm.GetById(id);
            var rlProduct= pm.GetList().Where(x => x.CategoryId == product.CategoryId);
            ViewBag.relatedProducts = rlProduct.ToList();
            return View(product);
        }

    }
}