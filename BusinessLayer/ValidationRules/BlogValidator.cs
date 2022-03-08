using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).Matches("[a-zA-Z]+$").WithMessage("Baslik bos gecilemez ve simbollar kullanilamaz");
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Baslik bos gecilemez ve simbollar kullanilamaz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Contenti yazin ve 20 karakterden cok olmali");
        }
    }
}
