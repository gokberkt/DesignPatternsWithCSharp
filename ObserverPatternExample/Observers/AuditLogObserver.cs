using ObserverPatternExample.Events;

namespace ObserverPatternExample.Observers
{
    public class AuditLogObserver : Abstractions.IObserver<UserRegisteredEvent>
    {
        public void Update(UserRegisteredEvent data)
        {
            Console.WriteLine($"[AUDIT] User registered → {data.UserId} at {data.RegisteredAt:O}");
        }
    }
}