namespace ObserverPatternExample.Events
{
    public record UserRegisteredEvent(Guid UserId, string Email, DateTime RegisteredAt);

}