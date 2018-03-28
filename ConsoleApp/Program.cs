using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationDelegate operation = Component.Operation;
            OperationDelegate operation1 = Decorators.Operation1(operation);
            OperationDelegate operation2 = Decorators.Operation2(operation1);

            operation2();
        }
    }
}