

namespace TheWeatherMonitoringApp.ClassLib
{
    public interface IPublisher
    {
        void register(IObserver observer);
        void unRegister(IObserver observer);
        void notify();
    }
}