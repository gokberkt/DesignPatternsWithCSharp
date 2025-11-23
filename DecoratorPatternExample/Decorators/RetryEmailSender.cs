using DecoratorPatternExample.Abstractions;

namespace DecoratorPatternExample.Decorators
{
    public class RetryEmailSender : EmailSenderDecorator
    {
        public RetryEmailSender(IEmailSender inner) : base(inner)
        {
        }

        public override void Send(string to, string subject, string body)
        {
            int retry = 0;

            while (true)
            {
                try
                {
                    base.Send(to, subject, body);
                    return;
                }
                catch (Exception ex)
                {
                    retry++;
                    Console.WriteLine($"[RETRY] Hata: {ex.Message} - Tekrar deneniyor ({retry})");

                    if (retry >= 3)
                        throw;
                }
            }
        }
    }
}