using AutoMapper;
using FluentValidation;
using poc_cqrs.Domain.Entities;

namespace poc_cqrs.Application.UseCases.GetByIdCustomerQuery
{
    public class GetByIdCustomerMapper : Profile
    {
        public GetByIdCustomerMapper()
        {
            CreateMap<Customer, GetByIdCustomerResponse>().ReverseMap();
        }
    }
}
