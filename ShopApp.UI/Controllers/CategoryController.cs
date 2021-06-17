using FluentValidation.Results;
using ShopApp.BusinessLayer.Concrete;
using ShopApp.BusinessLayer.ValidationRules;
using ShopApp.DataLayer.EntityFramework;
using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace ShopApp.UI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDAL());
        ProductManager pm = new ProductManager(new EFProductDAL());
        public ActionResult GetCategory(int id)
        {
            var categoryByID = pm.GetList().Where(x => x.CategoryId == id).ToList();
            return View(categoryByID);
        }
    }
}