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
    public class PaymentManager : IPaymentService
    {
        IPayment _payment;
        public PaymentManager(IPayment payment)
        {
            _payment = payment;
        }
        public Payment GetById(int id)
        {
            return _payment.Get(x => x.Id == id);
        }

        public List<Payment> GetList()
        {
            return _payment.List();
        }

        public void PaymentAdd(Payment payment)
        {
            _payment.Insert(payment);
        }

        public void PaymentDel(Payment payment)
        {
            _payment.Delete(payment);
        }

        public void PaymentUpdate(Payment payment)
        {
            _payment.Update(payment);
        }
    }
}
