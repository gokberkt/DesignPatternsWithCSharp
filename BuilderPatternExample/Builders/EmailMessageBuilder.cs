using BuilderPatternExample.Models;

namespace BuilderPatternExample.Builders
{
    public class EmailMessageBuilder
    {
        private readonly EmailMessage _message = new();

        public EmailMessageBuilder From(string from)
        {
            _message.From = from;
            return this;
        }

        public EmailMessageBuilder To(string to)
        {
            _message.To = to;
            return this;
        }

        public EmailMessageBuilder Subject(string subject)
        {
            _message.Subject = subject;
            return this;
        }

        public EmailMessageBuilder Body(string body)
        {
            _message.Body = body;
            return this;
        }

        public EmailMessageBuilder AddCc(string cc)
        {
            _message.Cc.Add(cc);
            return this;
        }

        public EmailMessageBuilder AddBcc(string bcc)
        {
            _message.Bcc.Add(bcc);
            return this;
        }

        public EmailMessageBuilder AddAttachment(string filePath)
        {
            _message.Attachments.Add(filePath);
            return this;
        }

        public EmailMessage Build()
        {
            if (string.IsNullOrWhiteSpace(_message.To))
                throw new InvalidOperationException("Alıcı (To) zorunludur!");

            return _message;
        }
    }
}