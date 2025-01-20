using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc_cqrs.Application.UseCases.DeleteCustomerCommand
{
    public class DeleteCustomerValidator : AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerValidator()
        {
            RuleFor(x => x.CustumerId).NotEmpty().NotNull();
        }
    }
}
