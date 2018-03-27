using System;

namespace ClassLibrary
{
    public class ConcreteDecorator2 : AbstractDecorator
    {
        public ConcreteDecorator2(ComponentInterface component) : base(component)
        {
        }

        public override void Operation()
        {
            _component.Operation();
            Console.WriteLine("ConcreateDecorator2 add behavior");
        }
    }
}