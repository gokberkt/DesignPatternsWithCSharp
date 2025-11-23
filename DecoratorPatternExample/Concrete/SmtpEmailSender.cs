using DecoratorPatternExample.Abstractions;

namespace DecoratorPatternExample.Concrete
{
    public class SmtpEmailSender : IEmailSender
    {
        public void Send(string to, string subject, string body)
        {
            Console.WriteLine("SMTP üzerinden mail gönderildi.");
        }
    }
}
