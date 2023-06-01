using System;

namespace SingletonClass {
    public class Singleton
    {
        private DateTime createTime
            private string name;

        private Singleton()
        {
            createTime = new DateTime();
            name = "CRUD App"
        }

        private static Singleton instance = null;

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();  //making sure we instantiate only one object 
            }
            return instance;
        }

        public void display()
        {
            print("Name of the app is " + instance.name);
        }

        public void start()
        {
            //adding functionalities
        }

    }

}