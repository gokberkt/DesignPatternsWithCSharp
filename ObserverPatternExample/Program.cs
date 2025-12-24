using ObserverPatternExample.Events;
using ObserverPatternExample.Observers;
using ObserverPatternExample.Services;
using ObserverPatternExample.Subjects;

namespace ObserverPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject<UserRegisteredEvent>();

            subject.Subscribe(new WelcomeEmailObserver());
            subject.Subscribe(new AuditLogObserver());
            subject.Subscribe(new AnalyticsObserver());

            var userService = new UserService(subject);

            userService.Register("ares@timurozu.com");

            Console.ReadLine();
        }
    }
}