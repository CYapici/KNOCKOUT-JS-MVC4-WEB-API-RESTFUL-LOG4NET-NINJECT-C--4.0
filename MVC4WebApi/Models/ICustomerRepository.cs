using System.Collections.Generic;
///
/// ON AIR ( RAM )  CRUD OPERATION INTERFACE
/// 
/// 
namespace MVC4WebApi.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> Get();
        bool TryGet(long id, out Customer cust);
        Customer Add(Customer cust);
        bool Delete(long id);
        bool Update(Customer cust);
    }
}