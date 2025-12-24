using ObserverPatternExample.Events;

namespace ObserverPatternExample.Observers
{
    public class WelcomeEmailObserver : Abstractions.IObserver<UserRegisteredEvent>
    {
        public void Update(UserRegisteredEvent data)
        {
            Console.WriteLine($"[EMAIL] Hoş geldin maili gönderildi → {data.Email}");
        }
    }

}