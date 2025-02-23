﻿namespace poc_cqrs.Application.UseCases.GetByIdCustomerQuery
{
    public class GetByIdCustomerResponse
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
    }
}
