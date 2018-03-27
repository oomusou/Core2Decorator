using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ComponentInterface c = new ConcreteComponent();
            ComponentInterface d1 = new ConcreteDecorator1(c);
            ComponentInterface d2 = new ConcreteDecorator2(d1);
            
            d2.Operation();
        }
    }
}