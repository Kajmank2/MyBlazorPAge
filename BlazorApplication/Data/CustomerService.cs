using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApplication.Data
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> Customers { get; set; }
        public CustomerService()
        {
            Customers = new List<Customer>();
            Customers.Add(new Customer(1, "Karol", "Łukasik", new DateTime(1992, 01, 02), "ka@gmail.com"));
            Customers.Add(new Customer(2, "Wacław", "Głukasik", new DateTime(1991, 12, 02), "ka3@gmail.com"));
            Customers.Add(new Customer(3, "Karol", "Łukasik", new DateTime(1995, 12, 12), "ka2@gmail.com"));
            Customers.Add(new Customer(4, "Karol", "Łukasik", new DateTime(1997, 11, 02), "ka1@gmail.com"));
        }
        public void Delete(Customer customer)
        {
            Customers.Remove(customer);
        }

        public List<Customer> AllCustomers()
        {
            return Customers;
        }

        public void Save(Customer customer)
        {
            Customers.Add(customer);
        }

        public Customer Update(Customer customer)
        {
            return customer;
        }

        public Customer GetCustomerbyId(int customerId)
        {
            return Customers.Where(custom => custom.Id == customerId).FirstOrDefault();
        }
    }
}
