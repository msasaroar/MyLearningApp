using System;
using MyLearningApp.Models;
using MyLearningApp.Services;
using MyLearningApp.Utilities;

class Program
{
    static void Main()
    {
        Console.WriteLine("✅ Welcome to MyLearningApp!");

        Customer customer = new Customer { Name = "Alice", Email = "alice@example.com" };
        EmailService emailService = new EmailService();
        emailService.SendWelcomeEmail(customer.Email);

        int result = MathUtilities.Add(5, 3);
        Console.WriteLine($"5 + 3 = {result}");

        string title = StringUtilities.ToTitleCase("hello world");
        Console.WriteLine($"Title Case: {title}");
    }
}
