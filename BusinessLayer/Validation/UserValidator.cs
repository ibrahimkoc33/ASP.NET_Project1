using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validation
{
	public class UserValidator:AbstractValidator<User>
	{
        public UserValidator()
        {
                RuleFor(x=>x.Name).NotEmpty().WithMessage("İsim boş olamaz");
                RuleFor(x=>x.Mail).NotEmpty().WithMessage("Mail boş olamaz");
                RuleFor(x=>x.Mail).EmailAddress().WithMessage("Geçersiz Mail. example@gmail.com şeklinde giriniz");
                RuleFor(x=>x.Username).NotEmpty().WithMessage("Username boş olamaz");
                RuleFor(x=>x.Password).NotEmpty().WithMessage("Password boş olamaz");
                RuleFor(x=>x.Name).MinimumLength(3).WithMessage("İsim en az 3 karekter olmalı");
        }
    }
}
