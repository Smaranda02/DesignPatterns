using System;
using EmployeeClass;

namespace FactoryClass
{
    public class Factory
    {
        public Factory()
        {
            static Employee ceo() { return Employee(10000, "boss"); }
            static Employee hr() { return Employee(4500, "human resources"); }
            static Employee programmer() { return Employee(7000, "developer"); }
            static Employee intern() { return Employee(500, "practicant"); }
            static Employee marketing() { return Employee(5500, "advertisment analyst"); }

        }
    }
}
