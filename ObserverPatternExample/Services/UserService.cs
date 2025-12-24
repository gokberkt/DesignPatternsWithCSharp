using ObserverPatternExample.Events;
using ObserverPatternExample.Subjects;

namespace ObserverPatternExample.Services
{
    public class UserService
    {
        private readonly Subject<UserRegisteredEvent> _userRegisteredSubject;

        public UserService(Subject<UserRegisteredEvent> userRegisteredSubject)
        {
            _userRegisteredSubject = userRegisteredSubject;
        }

        public void Register(string email)
        {
            var userId = Guid.NewGuid();

            Console.WriteLine($"[USER] Kayıt oluşturuldu → {email}");

            var @event = new UserRegisteredEvent(userId, email, DateTime.UtcNow);

            _userRegisteredSubject.Notify(@event);
        }
    }
}