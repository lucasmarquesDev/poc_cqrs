using poc_cqrs.Domain.Entities;

namespace poc_cqrs.Infrastructure.Repository
{
    public interface ICustomerRepository
    {
        Task<bool> Create(Customer customer);
        Task<bool> Delete(int customerId);
        Task<List<Customer>> GetAll();
        Task<Customer> GetById(int customerId);
    }
}