using poc_cqrs.Domain.Entities;

namespace poc_cqrs.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<bool> Create(Customer customer)
        {
            return true;
        }

        public async Task<bool> Delete(int customerId)
        {
            return true;
        }

        public async Task<List<Customer>> GetAll()
        {
            var customers = new List<Customer>();

            customers.Add(new Customer { Address = "r eudelio ramos 1", City = "sao paulo", CompanyName = "teste", Country = "brasil", CustomerId = 1, Name = "lucas j", Phone = "123", Region = "sul" });
            customers.Add(new Customer { Address = "r eudelio ramos 2", City = "sao paulo", CompanyName = "teste", Country = "brasil", CustomerId = 2, Name = "lucas j", Phone = "345", Region = "sul" });

            return customers;
        }

        public async Task<Customer> GetById(int customerId)
        {
            var customers = new List<Customer>();

            customers.Add(new Customer { Address = "r eudelio ramos 1", City = "sao paulo", CompanyName = "teste", Country = "brasil", CustomerId = Random.Shared.Next(0, 1000), Name = "lucas j", Phone = "123", Region = "sul" });
            customers.Add(new Customer { Address = "r eudelio ramos 2", City = "sao paulo", CompanyName = "teste", Country = "brasil", CustomerId = customerId, Name = "lucas j", Phone = "345", Region = "sul" });

            return customers.Where(x => x.CustomerId == customerId).FirstOrDefault();
        }
    }
}
