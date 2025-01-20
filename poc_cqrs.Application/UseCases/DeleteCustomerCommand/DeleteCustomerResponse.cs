using MediatR;

namespace poc_cqrs.Application.UseCases.DeleteCustomerCommand
{
    public class DeleteCustomerResponse
    {
        public bool Integration { get; set; }
    }
}