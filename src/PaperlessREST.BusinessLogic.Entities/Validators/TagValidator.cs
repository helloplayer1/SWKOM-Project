using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessREST.BusinessLogic.Entities.Validators
{
    public class TagValidator : AbstractValidator<Tag>
    {
        public TagValidator() {
            RuleFor(tag => tag.Id).NotNull().NotEmpty();
            RuleFor(tag => tag.Slug).NotNull().NotEmpty();
            RuleFor(tag => tag.Name).NotNull().NotEmpty();
            RuleFor(tag => tag.Color).NotNull().NotEmpty();
            RuleFor(tag => tag.Match).NotNull().NotEmpty();
            RuleFor(tag => tag.MatchingAlgorithm).NotNull().NotEmpty();
            RuleFor(tag => tag.IsInsensitive).NotNull().NotEmpty();
            RuleFor(tag => tag.IsInboxTag).NotNull().NotEmpty();
            RuleFor(tag => tag.DocumentCount).NotNull().NotEmpty();
        }
    }
}
