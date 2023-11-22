using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperlessREST.BusinessLogic.Entities.Validators
{
    public class DocumentTypeValidator : AbstractValidator<DocumentType>
    {
        public DocumentTypeValidator() {
            RuleFor(documentType => documentType.Id).NotNull().NotEmpty();
            RuleFor(documentType => documentType.Slug).NotNull().NotEmpty();
            RuleFor(documentType => documentType.Name).NotNull().NotEmpty();
            RuleFor(documentType => documentType.Match).NotNull().NotEmpty();
            RuleFor(documentType => documentType.MatchingAlgorithm).NotNull().NotEmpty();
            RuleFor(documentType => documentType.IsInsensitive).NotNull().NotEmpty();
            RuleFor(documentType => documentType.DocumentCount).NotNull().NotEmpty();
        }
    }
}
