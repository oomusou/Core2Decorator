using System;

namespace ClassLibrary
{
    public class ConcreteDecorator1: AbstractDecorator
    {
        public override void Operation()
        {
            _component.Operation();
            Console.WriteLine("ConcreateDecorator1 add behavior");
        }
    }
}