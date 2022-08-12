using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(2);
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MinimumLength(2);
            RuleFor(p => p.Password).MinimumLength(7);
            RuleFor(x => x.Password).Matches("[^a-zA-Z0-9]")
                    .WithMessage("Şifreniz en az bir büyük harf, küçük harf ve rakam içermelidir.");
        }
    }
}
