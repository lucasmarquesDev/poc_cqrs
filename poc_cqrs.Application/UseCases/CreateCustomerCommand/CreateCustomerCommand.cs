using MediatR;

namespace poc_cqrs.Application.UseCases.CreateCustomerCommand
{
    public class CreateCustomerCommand : IRequest<CreateCustomerResponse>
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }

        public CreateCustomerCommand(int customerId, string companyName, string phone, string country, string city, string region, string address, string name)
        {
            CustomerId = customerId;
            CompanyName = companyName;
            Phone = phone;
            Country = country;
            City = city;
            Region = region;
            Address = address;
            Name = name;
        }
    }
}
