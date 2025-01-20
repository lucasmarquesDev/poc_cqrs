using AutoMapper;
using MediatR;
using poc_cqrs.Domain.Entities;
using poc_cqrs.Infrastructure.Repository;

namespace poc_cqrs.Application.UseCases.CreateCustomerCommand
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerResponse>
    {
        public readonly ICustomerRepository _repository;
        public readonly IMapper _mapper;

        public CreateCustomerHandler(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreateCustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customerMap = _mapper.Map<Customer>(request);

            var result = await _repository.Create(customerMap);

            return new CreateCustomerResponse { Integration = result };
        }
    }
}
