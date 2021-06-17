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
    public class AdminController : BaseController
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDAL());
        ProductManager pm = new ProductManager(new EFProductDAL());
        // GET: Admin
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

            var maxProductofCategory = productList.GroupBy(x => x.Category.CategoryName).FirstOrDefault();
            ViewBag.maxProductofCategory = maxProductofCategory.Key;

            //Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark
            var IsActiveTrue = catList.Where(x => x.IsActive == true).Count();
            var IsActiveFalse = catList.Where(x => x.IsActive == false).Count();
            ViewBag.IsActive = IsActiveTrue - IsActiveFalse;

            return View();
        }

        public ActionResult CategoryList()
        {
            var categoryList = cm.GetList();
            return View(categoryList);
        }

        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAdd(p);
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
        public ActionResult UpdateCategory(int id)
        {

            var cat = cm.GetById(id);
            return View(cat);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            cm.CategoryUpdate(category);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var getCat = cm.GetById(id);
            cm.CategoryDel(getCat);
            return View(getCat);
        }


        public ActionResult ProductList()
        {
            var productList = pm.GetList();
            return View(productList);
        }

        public ActionResult AddProduct()
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.Id.ToString()
                                                  }).ToList();
            ViewBag.vlc = valueCategory;
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