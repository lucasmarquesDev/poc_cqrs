using FluentValidation;

namespace poc_cqrs.Application.UseCases.GetByIdCustomerQuery
{
    public class GetByIdCustomerValidator : AbstractValidator<GetByIdCustomerQuery>
    {
        public GetByIdCustomerValidator()
        {
            RuleFor(x => x.CustomerId).NotEmpty().NotNull();
        }
    }
}
