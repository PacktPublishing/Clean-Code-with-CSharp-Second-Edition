using System;

namespace CH13_CodeRefactoring.RefactoredCode
{
    public class PaymentProcessor
    {
        public bool ProcessPayment(CreditCard creditCard, decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount: C} using credit card ending in {creditCard.LastFourDigits}.");
            // More payment processing code...
            return true;
        }
    }
}
