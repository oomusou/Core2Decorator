using System;

namespace ClassLibrary
{
    public class ConcreteDecorator1: AbstractDecorator
    {
        public ConcreteDecorator1(ComponentInterface component) : base(component)
        {
        }

        public override void Operation()
        {
            _component.Operation();
            Console.WriteLine("ConcreateDecorator1 add behavior");
        }
    }
}