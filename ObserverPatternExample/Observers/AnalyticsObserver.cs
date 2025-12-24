using ObserverPatternExample.Events;

namespace ObserverPatternExample.Observers
{
    public class AnalyticsObserver : Abstractions.IObserver<UserRegisteredEvent>
    {
        public void Update(UserRegisteredEvent data)
        {
            Console.WriteLine($"[ANALYTICS] Event basıldı → user_registered ({data.UserId})");
        }
    }
}