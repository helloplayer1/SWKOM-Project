using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessREST.BusinessLogic.Entities.Validators
{
    public class UserInfoValidation : AbstractValidator<UserInfo>
    {
        public UserInfoValidation() {
            RuleFor(userInfo => userInfo.Username).NotNull().NotEmpty();
            RuleFor(userInfo => userInfo.Password).NotNull().NotEmpty();
        }
    }
}
