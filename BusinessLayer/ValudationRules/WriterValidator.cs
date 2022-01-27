using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValudationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı kısmı boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresiboş geçilemez ");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız.");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterli veri girişi yapınız.");
            RuleFor(x => x).Custom((x, context) =>
            {
                if (x.WriterPassword != x.WriterPasswordAgain)
                {
                    context.AddFailure(nameof(x.WriterPassword), "Şifreler aynı değil");
                }
            });
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.")
                    .Matches(@"[A-Z]+").WithMessage("Şifreniz en az 1 büyük harf içermelidir")
                    .Matches(@"[a-z]+").WithMessage("Şifreniz en az 1 küçük harf içermelidir")
                    .Matches(@"[0-9]+").WithMessage("Şifreniz en az 1 rakam içermelidir");
        }


    }
}
