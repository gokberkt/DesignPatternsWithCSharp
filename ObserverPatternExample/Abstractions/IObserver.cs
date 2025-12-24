namespace ObserverPatternExample.Abstractions
{
    public interface IObserver<in T>
    {
        void Update(T data);
    }
}