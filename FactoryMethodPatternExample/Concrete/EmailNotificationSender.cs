using FactoryMethodPatternExample.Abstractions;

namespace FactoryMethodPatternExample.Concrete
{
    public class EmailNotificationSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"[EMAIL] {message}");
        }
    }
}