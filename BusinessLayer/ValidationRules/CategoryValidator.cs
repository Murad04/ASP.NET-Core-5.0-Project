using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adini bos gecemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty()
                .MinimumLength(10)
                .WithMessage("Kategori hakkinda bilgi yazin ve bu bilgi 10 karakterden fazla olmali");
        }
    }
}
