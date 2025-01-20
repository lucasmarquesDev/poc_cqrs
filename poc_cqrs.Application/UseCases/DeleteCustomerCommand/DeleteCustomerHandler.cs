using MediatR;
using poc_cqrs.Infrastructure.Repository;

namespace poc_cqrs.Application.UseCases.DeleteCustomerCommand
{
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, DeleteCustomerResponse>
    {
        public readonly ICustomerRepository _repository;
        public DeleteCustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<DeleteCustomerResponse> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var result = await _repository.Delete(request.CustumerId);

            return new DeleteCustomerResponse { Integration = result };
        }
    }
}
