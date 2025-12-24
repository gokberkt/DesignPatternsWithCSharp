namespace ObserverPatternExample.Subjects
{
    public class Subject<T>
    {
        private readonly List<Abstractions.IObserver<T>> _observers = new();

        public void Subscribe(Abstractions.IObserver<T> observer)
            => _observers.Add(observer);

        public void Unsubscribe(Abstractions.IObserver<T> observer)
            => _observers.Remove(observer);

        public void Notify(T data)
        {
            foreach (var observer in _observers)
                observer.Update(data);
        }
    }
}