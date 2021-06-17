using ShopApp.BusinessLayer.Abstract;
using ShopApp.DataLayer.Abstract;
using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrder _order;
        public OrderManager(IOrder order)
        {
            _order = order;
        }
        public Order GetById(int id)
        {
            return _order.Get(x => x.Id == id);
        }

        public List<Order> GetList()
        {
            return _order.List();
        }

        public void OrderAdd(Order order)
        {
            _order.Insert(order);
        }

        public void OrderDel(Order order)
        {
            _order.Delete(order);
        }

        public void OrderUpdate(Order order)
        {
            _order.Update(order);
        }
    }
}
