using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApplication.Data
{
  public  interface ICustomerService
    {
        List<Customer> AllCustomers();
        Customer GetCustomerbyId(int customerId);
        Customer Update(Customer customer);
        void Save(Customer customer);
        void Delete(Customer customer);
    }
}
