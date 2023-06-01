using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeClass;
using FactoryClass;
using ObserverDP;
using SingletonClass;
//using DesignPatterns.Observer;

namespace DesignPatterns
{
    internal static class Program 
    {
        static void Main()
        {
            //Singleton
            Singleton app = Singleton.getInstance();
            Subject subj;
            app.start();

            //Observer
            Subject TeslaStock = new Subject("Tesla, Inc.", 185, 10000000);

            Observer investor1 = new Observer("Mihai", 10);
            investor1.AddSubscriber(TeslaStock);

            Observer investor2 = new Observer("Ion", 15);
            investor2.AddSubscriber(TeslaStock);


            Observer investor3 = new Observer("Tom", 5);
            investor3.AddSubscriber(TeslaStock);

            investor3.RemoveSubscriber(TeslaStock);
           

            TeslaStock.setNewPrice(175);

            Console.Read();


            //Factory
            Employee employee = null;
            string empRole = null;

            Console.Read(empRole);
            if (empRole == "hr")
                employee = Factory.hr();

        }
    }

}


