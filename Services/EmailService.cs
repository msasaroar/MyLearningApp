namespace MyLearningAppLibrary.Services
{
    public class EmailService
    {
        public void SendWelcomeEmail(string email)
        {
            Console.WriteLine($"Welcome email sent to {email}");
        }
    }
}

