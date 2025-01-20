using AutoMapper;
using poc_cqrs.Domain.Entities;

namespace poc_cqrs.Application.UseCases.GetAllCustomerQuery
{
    public class GetAllCustomerMapper : Profile
    {
        public GetAllCustomerMapper()
        {
            CreateMap<Customer, GetAllCustomerResponse>().ReverseMap();
        }
    }
}
