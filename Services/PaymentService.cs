using System;

namespace MyLearningApp.Services
{
    public class PaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:C}");
        }
    }
}

