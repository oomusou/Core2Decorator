using System;

namespace ClassLibrary
{
    public static class Decorators
    {
        public static Action Operation1(Action operation)
        {
            return () => 
            {
                operation();
                Console.WriteLine("ConcreateDecorator1 add behavior");
            };
        }

        public static Action Operation2(Action operation)
        {
            return () =>
            {
                operation();
                Console.WriteLine("ConcreateDecorator2 add behavior");
            };
        }
    }
}