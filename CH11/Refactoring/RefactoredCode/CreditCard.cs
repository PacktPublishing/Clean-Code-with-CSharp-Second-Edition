using System;
using System.Linq;

namespace CH13_CodeRefactoring.RefactoredCode
{
    public class CreditCard
    {
        public string Number { get; }

        public CreditCard(string number) 
        {
            if (!IsValidCreditCardNumber(number))
            {
                throw new ArgumentException("Invalid credit card format.", nameof(number));
            }

            Number = number;
        }

        public string LastFourDigits => Number.Length >= 4 ? Number.Substring(Number.Length - 4) : string.Empty;

        private bool IsValidCreditCardNumber(string number)
        {
            // Credit card number validation logic.
            return !string.IsNullOrEmpty(number) && number.Length == 16 && number.All(char.IsDigit);
        }
    }
}
