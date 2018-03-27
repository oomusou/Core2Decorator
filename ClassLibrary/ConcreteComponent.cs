using System;

namespace ClassLibrary
{
    public class ConcreteComponent : ComponentInterface
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteComponent Operation");
        }
    }
}