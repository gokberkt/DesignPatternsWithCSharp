using DecoratorPatternExample.Abstractions;

namespace DecoratorPatternExample.Decorators
{
    public class RateLimitEmailSender : EmailSenderDecorator
    {
        private int _count = 0;
        private DateTime _windowStart = DateTime.UtcNow;

        public RateLimitEmailSender(IEmailSender inner) : base(inner)
        {
        }

        public override void Send(string to, string subject, string body)
        {
            if ((DateTime.UtcNow - _windowStart).TotalSeconds > 60)
            {
                _windowStart = DateTime.UtcNow;
                _count = 0;
            }

            if (_count >= 10)
            {
                Console.WriteLine("[RATE LIMIT] Dakikada 10 mail sınırına ulaşıldı.");
                return;
            }

            _count++;

            base.Send(to, subject, body);
        }
    }
}