using AutoMapper;
using MediatR;
using poc_cqrs.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc_cqrs.Application.UseCases.GetAllCustomerQuery
{
    public class GetAllCustomerHandler : IRequestHandler<GetAllCustomerQuery, List<GetAllCustomerResponse>>
    {
        public readonly ICustomerRepository _repository;
        public readonly IMapper _mapper;
        public GetAllCustomerHandler(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetAllCustomerResponse>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            var result = _repository.GetAll();

            var responseMapper = _mapper.Map<List<GetAllCustomerResponse>>(result.Result);

            return responseMapper;
        }
    }
}
