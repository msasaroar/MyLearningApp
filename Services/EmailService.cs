using System;

namespace MyLearningApp.Services
{
    public class EmailService
    {
        public void SendWelcomeEmail(string email)
        {
            Console.WriteLine($"Welcome email sent to {email}");
        }
    }
}

