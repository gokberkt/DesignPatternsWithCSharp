using FactoryMethodPatternExample.Abstractions;

namespace FactoryMethodPatternExample.Creators
{
    public abstract class NotificationService
    {
        public void Notify(string message)
        {
            var sender = CreateSender();
            sender.Send(message);
        }

        protected abstract INotificationSender CreateSender();
    }
}