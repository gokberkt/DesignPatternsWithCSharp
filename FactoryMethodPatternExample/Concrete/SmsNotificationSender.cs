using FactoryMethodPatternExample.Abstractions;

namespace FactoryMethodPatternExample.Concrete
{
    public class SmsNotificationSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"[SMS] {message}");
        }
    }
}