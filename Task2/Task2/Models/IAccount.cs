using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Models
{
     interface IAccount
    {
        
        bool PasswordChecker(ref string password);
        void ShowInfo();
    }
}
