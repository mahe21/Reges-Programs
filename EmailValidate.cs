using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExamples
{
    internal class EmailValidate
    {
        public static void Main(string[] args)
        {
            string EmailPattern = @"^[a-z]{3}.[a-z]{3}@[a-z]{3,11}\.co$";
            Console.WriteLine("Enter Email Addres: ");
            string emailAddress = Console.ReadLine();

            if (Regex.IsMatch(emailAddress, EmailPattern))
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }
        }
    }
}
