/*using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegexExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter PinCode:");
            string pincode=Console.ReadLine();
            Regex Pincoderegex = new Regex(Patterns.PinCodePattern);
            var Pincodeflag= Pincoderegex.IsMatch(pincode);
            Console.WriteLine(Pincodeflag);

        }

        public class Patterns
        {
            public static string PinCodePattern = "^[0-9]{6}$";
        }
    }
}*/
            