using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adi soyadi bos gecilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Gecerli bir mail adresi yazin");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Sifre yazin");
            RuleFor(x => x.WriterPassword).MinimumLength(8).WithMessage("Sifre en az 8 karakter olamli");
            RuleFor(x => x.WriterPassword).Equal(x => x.WriterPassword2).WithMessage("Eslesme hatasi");
        }
        
    }
}
