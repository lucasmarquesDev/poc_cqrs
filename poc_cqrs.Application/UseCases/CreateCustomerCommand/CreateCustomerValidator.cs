using FluentValidation;

namespace poc_cqrs.Application.UseCases.CreateCustomerCommand
{
    public class CreateCustomerValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerValidator()
        {
            RuleFor(x => x.CustomerId).NotEmpty().NotNull();
            RuleFor(x => x.Address).NotEmpty().NotNull();
            RuleFor(x => x.Phone).NotEmpty().NotNull();
            RuleFor(x => x.City).NotEmpty().NotNull();
            RuleFor(x => x.CompanyName).NotEmpty().NotNull();
            RuleFor(x => x.Country).NotEmpty().NotNull();
            RuleFor(x => x.Region).NotEmpty().NotNull();
            RuleFor(x => x.Name).NotEmpty().NotNull();
        }
    }
}
