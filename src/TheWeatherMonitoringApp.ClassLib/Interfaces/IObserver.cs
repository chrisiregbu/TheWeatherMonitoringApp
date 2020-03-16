//
//  IObserver interface is implemented by all observers
// All weather components implement this interface, this gives the publisher a common interface
// to update all registered observers
//
public interface IObserver    
{
        void update(float temp, float humidity, float pressure);
}