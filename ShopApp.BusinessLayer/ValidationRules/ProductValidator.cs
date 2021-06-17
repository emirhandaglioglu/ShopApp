using FluentValidation;
using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BusinessLayer.ValidationRules
{
    public class ProductValidator   :AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş bırakılamaz");
            RuleFor(x => x.StockAmount).NotEmpty().WithMessage("Boş bırakılamaz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Boş bırakılamaz");
            //RuleFor(x => x.Category).NotEmpty().WithMessage("Boş bırakılamaz");

        }
    }
}
