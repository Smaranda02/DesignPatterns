using System;



public interface IObserver
{
    // Receive Notification from Subject
    void UpdatePrice(double price);
    void UpdateVenue(double stockPrice);
}