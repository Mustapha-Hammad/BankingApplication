using BankApplicationAhmed.Models;
using BankApplicationAhmed.Services;
using System;
using System.Collections.Generic;

namespace BankApplicationAhmed
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to soo so Bank \n \n \n What would you like to do \n\n\n To Register press 1 \n To log in press 2");





            var customerService = new CustomerService();
            var customers = new List<Customer>
            {
                new Customer
                {
                    FirstName = "Ahmed",
                    LastName = "Bolu",
                    Address = "Gaa Saka Oke fomo",
                    Age = 25,
                    Email = "HammedMustapha@gmail.com",
                    Password = "Password1",
                    PhoneNumber = "0884934873847"
                },
             new Customer
            {
                FirstName = "Ahmed",
                LastName = "Bolu",
                Address = "Gaa Saka Oke fomo",
                Age = 25,
                Email = "aMustapha@gmail.com",
                Password = "Password1",
                PhoneNumber = "0884934873847"
            },

            new Customer
            {
                FirstName = "Ahmed",
                LastName = "Bolu",
                Address = "Gaa Saka Oke fomo",
                Age = 25,
                Email = "HammedMtapha@gmail.com",
                Password = "Password1",
                PhoneNumber = "0884934873847"
            }
            };



            foreach (var customer in customers)
            {

                customerService.Register(customer);

            };


            var result = customerService.GetCustomers();

            foreach (var item in result)
            {
                Console.WriteLine($"Name {item.FirstName} {item.LastName}  ,  Age: {item.Age} , Email {item.Email}");
            }


        }
    }
}
