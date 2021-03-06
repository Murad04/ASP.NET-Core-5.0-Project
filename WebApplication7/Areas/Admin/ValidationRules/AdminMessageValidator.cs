using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Areas.Admin.ValidationRules
{
    public class AdminMessageValidator: AbstractValidator<Message2>
    {
        public AdminMessageValidator()
        {
            RuleFor(x => x.Message_Context).NotEmpty().WithMessage("Mesaj yazınız!");
            RuleFor(x => x.Message_Receiver).NotEmpty().WithMessage("Alıcı yazınız!");
            RuleFor(x => x.Message_Title).NotEmpty().WithMessage("Konu yazınız!");
        }
    }
}
