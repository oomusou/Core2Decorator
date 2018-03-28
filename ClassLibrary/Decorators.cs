using System;

namespace ClassLibrary
{
    public static class Decorators
    {
        public static OperationDelegate Operation1(OperationDelegate operation)
        {
            return () => 
            {
                operation();
                Console.WriteLine("ConcreateDecorator1 add behavior");
            };
        }

        public static OperationDelegate Operation2(OperationDelegate operation)
        {
            return () =>
            {
                operation();
                Console.WriteLine("ConcreateDecorator2 add behavior");
            };
            
            
        }

    }
}