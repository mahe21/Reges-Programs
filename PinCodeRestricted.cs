using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExamples
{
    internal class PinCodeRestricted
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Pincode: ");
            string pinCode = Console.ReadLine();
            string PincodeRegexNumeric = "^[0-9]{6}$";

            if(Regex.IsMatch(pinCode, PincodeRegexNumeric))
            {
                Console.WriteLine("Valid pincode.");
            }
            else
            {
                Console.WriteLine("Invalid Pincode.");
            }
        }
    }
}
