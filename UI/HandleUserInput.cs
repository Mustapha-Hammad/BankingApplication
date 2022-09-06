using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplicationAhmed.UI
{
    public class HandleUserInput
    {
        public bool ValidateWelcomeOptions(string input)
        {
            
            if (!(input == "1" || input == "2"))
                return false;
            return true;

           
        }

        private void HandleLogin()
        {
            throw new NotImplementedException();
        }

        private void HandleRegister()
        {
            throw new NotImplementedException();
        }
    }
}
