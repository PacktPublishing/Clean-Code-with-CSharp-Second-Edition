using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;
using System.Text;
using System;

namespace CH13_CodeRefactoring.ProblemCode
{
    public class PaymentProcessor
    {
        // Primitive obsession example
        public bool ProcessPayment(string creditCardNumber, decimal amount)
        {
            // Validate credit card number format
            if (!IsValidCreditCardNumber(creditCardNumber))
            {
                Console.WriteLine("Invalid credit card number format.");
                return false;
            }
            // Perform payment processing logic
            Console.WriteLine($"Processing payment of { amount: C} using credit card ending in { GetLastFourDigits(creditCardNumber)}.");
            // More payment processing code...
            return true;
        }

        // Primitive obsession: Credit card number validation logic
        private bool IsValidCreditCardNumber(string creditCardNumber)
        {
            // Simplified credit card number validation logic
            // Check length, format, etc.
            return !string.IsNullOrEmpty(creditCardNumber) &&
            creditCardNumber.Length == 16 && creditCardNumber.All(char.IsDigit);
        }

        // Primitive obsession: Extracting last four digits from a credit card number
        private string GetLastFourDigits(string creditCardNumber)
        {
            return creditCardNumber.Length >= 4 ? creditCardNumber.Substring(creditCardNumber.Length - 4) : string.Empty;
        }
    }
}
