namespace ClassLibrary
{
    public abstract class AbstractDecorator : ComponentInterface
    {
        protected ComponentInterface _component;
        
        protected AbstractDecorator(ComponentInterface component)
        {
            _component = component;
        }

        public abstract void Operation();
    }
}