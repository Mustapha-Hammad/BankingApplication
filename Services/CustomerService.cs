using BankApplicationAhmed.Data;
using BankApplicationAhmed.Dto;
using BankApplicationAhmed.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplicationAhmed.Services
{
    public class CustomerService
    {
        BankData bankData = new BankData();

        public bool Register(Customer customer)
        {
            var result  = bankData.AddCustomer(customer);

            return result;
            
        }

        public bool LogIn(LoginRequestDto logInRequest)
        {
            var result = bankData.LogIn(logInRequest);
            return result;
        }
       

        public List<Customer> GetCustomers()
        {
            return bankData.GetCustomers();
        }
    }

    
}
