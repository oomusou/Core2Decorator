using System;

namespace ClassLibrary
{
    public class ConcreteDecorator2 : AbstractDecorator
    {
        public override void Operation()
        {
            _component.Operation();
            Console.WriteLine("ConcreateDecorator2 add behavior");
        }
    }
}