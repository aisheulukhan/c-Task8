using System;

namespace Task2.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullname = "Ayse Uluxanova";
            string password = "A45874a487845";
            string email = "ayse.uluxanova@gmail.com";
            User u = new User(email, password, fullname);
            Console.WriteLine(u.PasswordChecker(ref password));
            u.ShowInfo();
            User u1 = new User("ayse.uluxanova@gmail.com", "A45874a487845", "Ayse Uluxanova");
            u1.ShowInfo();
            

        }    
    }
}


