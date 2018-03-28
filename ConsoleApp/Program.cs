using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action operation = Component.Operation;
            Action operation1 = Decorators.Operation1(operation);
            Action operation2 = Decorators.Operation2(operation1);

            operation2();
        }
    }
}