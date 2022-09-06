using BankApplicationAhmed.Dto;
using BankApplicationAhmed.Models;
using BankApplicationAhmed.Services;
using BankApplicationAhmed.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BankApplicationAhmed
{
    class Program
    {
        static void Main(string[] args)
        {
            var uI = new UserInterface();
            var uIInputs = new HandleUserInput();
            var customerService = new CustomerService();

            var stringBuilder = new StringBuilder();

            bool initialState = false;

            var userInput = string.Empty;
            while(!initialState)
            {
                Thread.Sleep(500);
                stringBuilder.Append(uI.WelcomeMessage());
                stringBuilder.Append(uI.WhatWouldYouLikeToDoToday());
                stringBuilder.Append(uI.WelcomeOptions());

                Console.WriteLine(stringBuilder.ToString());
                var welcomeOption = Console.ReadLine();
                initialState = uIInputs.ValidateWelcomeOptions(welcomeOption);

                Console.WriteLine(uI.YouEnteredWrongInput());
                userInput = welcomeOption;
            }

            if(userInput == "1") /// For user registration
            {
                var customer = new Customer();
                Console.WriteLine("Enter your firstName");
                customer.FirstName = Console.ReadLine();
                Console.WriteLine("Enter your LastName");
                customer.LastName = Console.ReadLine();

                Console.WriteLine("Enter your Address");
                customer.Address = Console.ReadLine();

                Console.WriteLine("Enter your Email");
                customer.Email = Console.ReadLine();

                Console.WriteLine("Enter your Age");
                customer.Age = Convert.ToInt32(Console.ReadLine()) ;

                Console.WriteLine("Enter your Phone Number");
                customer.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Enter your Password");
                customer.Password = Console.ReadLine();

                var registerService = customerService.Register(customer);
                if (registerService)
                    Console.WriteLine("Registration successful");


            }
            else // For user Log in
            {
                var logInDto = new LoginRequestDto();
                Console.WriteLine("Enter your Email");
                logInDto.Email = Console.ReadLine();

                Console.WriteLine("Enter your Password");
                logInDto.Password = Console.ReadLine();

                var logIn = customerService.LogIn(logInDto);

                if (logIn)
                {
                    Console.WriteLine("Log in was successful");
                }
                else
                {
                    Console.WriteLine("Log in was not succesful");
                }

            }

        }
    }
}
