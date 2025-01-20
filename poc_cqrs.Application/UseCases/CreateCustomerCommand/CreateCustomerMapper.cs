using AutoMapper;
using poc_cqrs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poc_cqrs.Application.UseCases.CreateCustomerCommand
{
    public class CreateCustomerMapper : Profile
    {
        public CreateCustomerMapper()
        {
            CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
        }
    }
}
