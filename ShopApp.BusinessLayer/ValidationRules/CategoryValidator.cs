using FluentValidation;
using ShopApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş bırakılamaz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("En fazla 20 karakter");

        }
    }
}
