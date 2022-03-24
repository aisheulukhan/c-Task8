using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task2.Models
{
     class User : IAccount
    {
        private int _id;
        private string _password;
        private string _fullName;
        private string _email;
        public string FullName { get; set; }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(ref value) == true)
                {
                    _password = value;
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (EmailChecker(value))
                {
                    _email = value;
                }
            }

        }
        public User(string email, string password, string fullname)
        {
            this.FullName = fullname;
            this.Email = email;
            //PasswordChecker(password);
            this.Password = password;
            //if (PasswordChecker(ref password) == true)
            //{
            //    Password = password;
            //    _id++;
            //}

            _id++;
            _id = Id;

        }
        
        public bool PasswordChecker( ref string password)
        {
            Regex regexpass = new Regex("^[A-Za-z0-9]{8,}$");
            //return Regex.IsMatch("A45874487845", password);
            Match match = regexpass.Match(password);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        public bool EmailChecker(string email)
        {
            Regex regexemail = new Regex(@"^([^\W])([a-z\d\.\-_]+)@([a-z\d\-]+\.)([a-z]{2,3})$");
            return Regex.IsMatch("ayse.uluxanova@gmail.com", email);

        }
        public void ShowInfo()
        {
            Console.WriteLine("Id"+_id);
            Console.WriteLine("Full Name"+FullName);
            Console.WriteLine("Email" + Email);
            Console.WriteLine("Paswoord"+ Password);
        }

    }
}
