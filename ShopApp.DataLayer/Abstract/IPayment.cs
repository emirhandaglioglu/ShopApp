using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataLayer.Abstract
{
    public interface IPayment : IRepository<Payment>
    {
    }
}
