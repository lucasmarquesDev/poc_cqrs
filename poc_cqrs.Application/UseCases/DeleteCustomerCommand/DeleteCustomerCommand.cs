using MediatR;

namespace poc_cqrs.Application.UseCases.DeleteCustomerCommand
{
    public class DeleteCustomerCommand : IRequest<DeleteCustomerResponse>
    {
        public int CustumerId { get; set; }

        public DeleteCustomerCommand(int custumerId)
        {
            CustumerId = custumerId;
        }
    }
}
