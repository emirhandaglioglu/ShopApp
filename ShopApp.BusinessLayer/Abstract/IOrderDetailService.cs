using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BusinessLayer.Abstract
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetList();
        void OrderDetailAdd(OrderDetail orderDetail);
        void OrderDetailDel(OrderDetail orderDetail);
        void OrderDetailUpdate(OrderDetail orderDetail);
        OrderDetail GetById(int id);
    }
}
