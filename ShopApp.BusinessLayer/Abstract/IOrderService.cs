using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BusinessLayer.Abstract
{
    public interface IOrderService 
    {
        List<Order> GetList();
        void OrderAdd(Order order);
        void OrderDel(Order order);
        void OrderUpdate(Order order);

        Order GetById(int id);
    }
}
