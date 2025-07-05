using BuilderPatternExample.Builders;

namespace BuilderPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var email = new EmailMessageBuilder()
                .From("gokberk@example.com")
                .To("kubra@example.com")
                .Subject("Toplantı Hatırlatma")
                .Body("Yarın saat 10:00'da toplantımız var.")
                .AddCc("ibrahim@example.com")
                .AddAttachment("meeting_agenda.pdf")
                .Build();

            email.Send();

            Console.ReadLine();
        }
    }
}
