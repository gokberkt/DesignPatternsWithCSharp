using DecoratorPatternExample.Abstractions;

namespace DecoratorPatternExample.Decorators
{
    public class LoggingEmailSender : EmailSenderDecorator
    {
        public LoggingEmailSender(IEmailSender inner) : base(inner)
        {
        }

        public override void Send(string to, string subject, string body)
        {
            Console.WriteLine($"[LOG] Mail gönderiliyor → To: {to}, Subject: {subject}");
            base.Send(to, subject, body);
            Console.WriteLine("[LOG] Mail gönderimi tamamlandı.");
        }
    }
}
