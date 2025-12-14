using FactoryMethodPatternExample.Creators;

namespace FactoryMethodPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService service;

            var type = "Email";

            service = type switch
            {
                "Email" => new EmailNotificationService(),
                "Sms" => new SmsNotificationService(),
                _ => throw new NotSupportedException()
            };

            service.Notify("Factory Method Notification!");

            Console.ReadLine();
        }
    }
}
