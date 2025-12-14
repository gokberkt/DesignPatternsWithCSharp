using FactoryMethodPatternExample.Abstractions;
using FactoryMethodPatternExample.Concrete;

namespace FactoryMethodPatternExample.Creators
{
    public class EmailNotificationService : NotificationService
    {
        protected override INotificationSender CreateSender()
        {
            return new EmailNotificationSender();
        }
    }
}