using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExamples
{
    internal class RegexPincode
    {
        public static void Main(string[] args)
        {

            string pinPattern = @"^(\d{6}|\d{3}\s*\d{3})$";
            string pinCode1 = "400088";
            string pinCode2 = "400 088";

            if (Regex.IsMatch(pinCode1, pinPattern))
            {
                Console.WriteLine("Valid PIN code: " + pinCode1);
            }
            else
            {
                Console.WriteLine("Invalid PIN code: " + pinCode1);
            }

            if (Regex.IsMatch(pinCode2, pinPattern))
            {
                Console.WriteLine("Valid PIN code: " + pinCode2);
            }
            else
            {
                Console.WriteLine("Invalid PIN code: " + pinCode2);
            }
        }
    }
}
