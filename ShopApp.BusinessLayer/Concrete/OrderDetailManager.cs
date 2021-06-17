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
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetail _orderDetail;
        public OrderDetailManager(IOrderDetail orderDetail)
        {
            _orderDetail = orderDetail;
        }
        public OrderDetail GetById(int id)
        {
            return _orderDetail.Get(x => x.Id == id);
        }

        public List<OrderDetail> GetList()
        {
            return _orderDetail.List();
        }

        public void OrderDetailAdd(OrderDetail orderDetail)
        {
            _orderDetail.Insert(orderDetail);
        }

        public void OrderDetailDel(OrderDetail orderDetail)
        {
            _orderDetail.Delete(orderDetail);
        }

        public void OrderDetailUpdate(OrderDetail orderDetail)
        {
            _orderDetail.Update(orderDetail);
        }
    }
}
