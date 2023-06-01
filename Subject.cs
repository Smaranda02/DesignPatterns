using System;

namespace ObserverDP
{
	public class Subject : ISubject
	{
        // The List of Observer is going to store in the following collection object
        private List<IObserver> observers = new List<IObserver>();

        //The following properties are going to store the Product Information
        private double stockPriceCurrent { get; set; }
        private double stockPriceNew { get; set; }
        private int stockName { get; set; }
        private double volume { get; set; }


        public Subject(double stockPriceCurrent, int stockName, double volume)
		{
            this.stockPriceCurrent = stockPriceCurrent;
            this.stockName = stockName;
            this.volume = volume;

            foreach (IObserver observer in observers)
            {
                observer.UpdateVenue(stockPriceCurrent);

            }

        }


        public getStockPrice()
        {
            return stockPriceCurrent;
        }

       
        public void setNewPrice(double price)
        {
            this.stockPriceNew = price;
            Console.WriteLine("Price changed from " + stockPriceCurrent " to " + stockPriceNew);
            NotifyObservers();
            stockPriceCurrent = stockPriceNew;
        }

        // The observer will register with the portofolio using the following method
        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("Observer Added : " + ((Observer)observer).UserName);
            observers.Add(observer);
        }


        // The observer will unregister from the Product using the following method
        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("Observer Removed : " + ((Observer)observer).UserName);
            observers.Remove(observer);
        }


        // The following Method will be sent notifications to all observers
        public void NotifyObservers()
        {
            Console.WriteLine("Stock Name :"
                            + stockName + " changed price from"
                            + this.stockPriceCurrent + " to " + this.stockPriceNew "so, notifying all Registered users ");
            Console.WriteLine();

            foreach (IObserver observer in observers)
            {
                //By Calling the Update method, we are sending notifications to observers
                observer.UpdatePrice(stockPriceNew);
                observer.UpdateVenue(stockPriceNew);

            }
        }

    }
}
