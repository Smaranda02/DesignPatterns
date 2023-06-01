using System;

namespace ObserverDP
{
	public class Observer : IObserver 
	{ 
	 //The following Property is going to hold the observer's name
        public string UserName { get; set; }
        private double venue { get; set; }
        private double stocksOwned { get; set; }

        public Observer(string userName, double stocksOwned)
		{
			UserName = userName;
            this.stocksOwned = stocksOwned;
		}

        //Registering the Observer with the Subject
        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }


        //Removing the Observer from the Subject
        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }


        //Observer will get a notification from the Subject using the following Method
        public void UpdatePrice(double price)
        {
            Console.WriteLine("Hello " + UserName + ", the price for the stock is now " + price);
        }

        public void UpdateVenue(double stockPrice)
        {
            //Console.WriteLine("Hello " + UserName + ", the price for the stock is now " + price);
            venue = this.stocksOwned * stockPrice;
        }

    }
}
