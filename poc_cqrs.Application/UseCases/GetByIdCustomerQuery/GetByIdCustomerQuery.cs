using MediatR;

namespace poc_cqrs.Application.UseCases.GetByIdCustomerQuery
{
    public class GetByIdCustomerQuery : IRequest<GetByIdCustomerResponse>
    {
        public int CustomerId { get; set; }

        public GetByIdCustomerQuery(int customerId)
        {
            CustomerId = customerId;
        }
    }
}
