using MediatR;

namespace poc_cqrs.Application.UseCases.GetAllCustomerQuery
{
    public class GetAllCustomerQuery : IRequest<List<GetAllCustomerResponse>>
    {

    }
}
