using DecoratorPatternExample.Concrete;
using DecoratorPatternExample.Decorators;

namespace DecoratorPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emailSender =
                new RetryEmailSender(
                    new LoggingEmailSender(
                        new RateLimitEmailSender(
                            new SmtpEmailSender())));

            emailSender.Send("x@example.com", "Merhaba", "Nasılsın?");
        }
    }
}