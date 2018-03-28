using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ComponentInterface c = new ConcreteComponent();
            var d1 = new ConcreteDecorator1().Decorate(c);
            var d2 = new ConcreteDecorator2().Decorate(d1);
            d2.Operation();
        }
    }
}