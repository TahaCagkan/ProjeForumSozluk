using FluentValidation;
using ProjeForumSozluk.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeForumSozluk.BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz!!!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu adını boş geçemezsiniz!!!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adını boş geçemezsiniz!!!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen 3 karakterden fazla değer girişi yapmayınız!!!");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen 3 karakterden az değer girişi yapmayınız!!!");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın!!!");

        }
    }
}
