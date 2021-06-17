using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BusinessLayer.Abstract
{
    public interface IPaymentService
    {
        List<Payment> GetList();
        void PaymentAdd(Payment payment);
        void PaymentDel(Payment payment);
        void PaymentUpdate(Payment payment);

        Payment GetById(int id);
    }
}
