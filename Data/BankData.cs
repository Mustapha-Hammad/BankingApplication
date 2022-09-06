using BankApplicationAhmed.Models;
using BankApplicationAhmed.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplicationAhmed.Data
{
    
    public class BankData
    {
        private List<Customer> Customers = new List<Customer>();

       public bool AddCustomer(Customer customer)
        {
            if (Customers.Any(x => x.Email == customer.Email))
                return false;

            Customers.Add(customer);
            return true ;
       }

       public bool LogIn(LoginRequestDto logInRequest)
       {
            var user = Customers.FirstOrDefault(x => x.Email == logInRequest.Email);
            if (user == null) return false;

            if (user.Password != logInRequest.Password) return false;

            return true;
            
       }

       public List<Customer> GetCustomers()
        {
            return Customers.ToList();
        }
    }
}
