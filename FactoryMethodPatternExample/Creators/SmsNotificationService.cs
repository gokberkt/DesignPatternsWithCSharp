using FactoryMethodPatternExample.Abstractions;
using FactoryMethodPatternExample.Concrete;

namespace FactoryMethodPatternExample.Creators
{
    public class SmsNotificationService : NotificationService
    {
        protected override INotificationSender CreateSender()
        {
            return new SmsNotificationSender();
        }
    }
}