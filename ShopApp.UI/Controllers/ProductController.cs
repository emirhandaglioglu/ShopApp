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
        // GET: Product
        public ActionResult Index()
        {
            var productList = pm.GetList();
            return View(productList);
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            ProductValidator productValidator = new ProductValidator();
            ValidationResult results = productValidator.Validate(p);
            if (results.IsValid)
            {
                pm.ProductAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var pro = pm.GetById(id);
            return View(pro);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product p)
        {
            pm.ProductUpdate(p);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(int id)
        {
            var delPro = pm.GetById(id);
            pm.ProductDel(delPro);
            return View();
        }

    }
}