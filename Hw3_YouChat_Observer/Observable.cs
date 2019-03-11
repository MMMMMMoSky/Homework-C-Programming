namespace Hw3_YouChat_Observer
{
    public interface Observable
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObservers();
    }
}