using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessREST.BusinessLogic.Entities.Validators
{
    public class CorrespondentValidation : AbstractValidator<Correspondent>
    {
        public CorrespondentValidation(){
            RuleFor(correspondent => correspondent.Id).NotNull().NotEmpty();
            RuleFor(correspondent => correspondent.Slug).NotNull().NotEmpty();
            RuleFor(correspondent => correspondent.Name).NotNull().NotEmpty();
            RuleFor(correspondent => correspondent.Match).NotNull().NotEmpty();
            RuleFor(correspondent => correspondent.MatchingAlgorithm).NotNull().NotEmpty();
            RuleFor(correspondent => correspondent.IsInsensitive).NotNull().NotEmpty();
            RuleFor(correspondent => correspondent.DocumentCount).NotNull().NotEmpty();
            RuleFor(correspondent => correspondent.LastCorrespondence).NotNull().NotEmpty();
        }
    }
}
