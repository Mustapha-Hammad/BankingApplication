using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplicationAhmed.UI
{
    public class UserInterface
    {
        public string WelcomeMessage()
        {
            return ("\t\tWelcome to Ahmad's Bank \n\n\n");

        }

        public string WhatWouldYouLikeToDoToday()
        {
            return "\t\tWhat would you like to do today?\n\n";

        }
        
        public string WelcomeOptions()
        {
            var builder = new StringBuilder();
            
            builder.Append("\t\tTo Register Press ====================>   1\n");
            builder.Append("\t\tTo Login Press    ====================>   2\n");
            return builder.ToString();

        }

        public string YouEnteredWrongInput()
        {
            return "\t\tYou entered wrong input\n";
        }
    }
}
