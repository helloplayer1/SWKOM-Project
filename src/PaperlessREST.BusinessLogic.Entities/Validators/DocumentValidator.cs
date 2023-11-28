using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace PaperlessREST.BusinessLogic.Entities.Validators
{
    public class DocumentValidator: AbstractValidator<Document>
    {
        public DocumentValidator() {
            RuleFor(document => document.Id).NotNull().NotEmpty();
            RuleFor(document => document.Correspondent).NotNull().NotEmpty();
            RuleFor(document => document.DocumentType).NotNull().NotEmpty();
            RuleFor(document => document.StoragePath).NotNull().NotEmpty();
            RuleFor(document => document.Title).NotNull().NotEmpty();
            RuleFor(document => document.Content).NotNull().NotEmpty();
            RuleFor(document => document.Tags).NotNull().NotEmpty();
            RuleFor(document => document.Created).NotNull().NotEmpty();
            RuleFor(document => document.CreatedDate).NotNull().NotEmpty();
            RuleFor(document => document.Modified).NotNull().NotEmpty();
            RuleFor(document => document.Added).NotNull().NotEmpty();
            RuleFor(document => document.ArchiveSerialNumber).NotNull().NotEmpty();
            RuleFor(document => document.OriginalFileName).NotNull().NotEmpty();
            RuleFor(document => document.ArchivedFileName).NotNull().NotEmpty();
        }
    }
}
