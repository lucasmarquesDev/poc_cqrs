using AutoMapper;
using MediatR;
using poc_cqrs.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc_cqrs.Application.UseCases.GetByIdCustomerQuery
{
    public class GetByIdCustomerHandler : IRequestHandler<GetByIdCustomerQuery, GetByIdCustomerResponse>
    {
        public readonly ICustomerRepository _repository;
        public readonly IMapper _mapper;

        public GetByIdCustomerHandler(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetByIdCustomerResponse> Handle (GetByIdCustomerQuery request, CancellationToken cancellationToken)
        {
            var resul = _repository.GetById(request.CustomerId);

            var resultMap = _mapper.Map<GetByIdCustomerResponse>(resul.Result);

            return resultMap;
        }
    }
}
