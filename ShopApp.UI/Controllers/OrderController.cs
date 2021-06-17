using ShopApp.BusinessLayer.Concrete;
using ShopApp.DataLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopApp.UI.Controllers
{
    public class OrderController : BaseController
    {
        OrderManager om = new OrderManager(new EFOrderDAL());
        OrderDetailManager odm = new OrderDetailManager(new EFOrderDetailsDAL());
        PaymentManager pm = new PaymentManager(new EFPaymentDAL());

        // GET: Order
        public ActionResult Index()
        {
            var orderList = om.GetList();
            return View(orderList);
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            var payment = pm.GetList().Where(x => x.OrderId == id).FirstOrDefault();
            var list = odm.GetList().Where(x => x.OrderId == id).ToList();
            ViewBag.customer = list.Select(x => x.Order.UserInfo).FirstOrDefault();
            ViewBag.payment = payment;
            return View(list);
        }
    }
}