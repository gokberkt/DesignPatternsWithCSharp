using DecoratorPatternExample.Abstractions;

namespace DecoratorPatternExample.Decorators
{
    public abstract class EmailSenderDecorator : IEmailSender
    {
        private readonly IEmailSender _inner;

        protected EmailSenderDecorator(IEmailSender inner)
        {
            _inner = inner;
        }

        public virtual void Send(string to, string subject, string body)
        {
            _inner.Send(to, subject, body);
        }
    }
}