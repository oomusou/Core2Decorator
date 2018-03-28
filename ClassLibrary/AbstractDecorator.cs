using System;

namespace ClassLibrary
{
    public abstract class AbstractDecorator : ComponentInterface, DecorateInterface
    {
        protected ComponentInterface _component;
        
        public abstract void Operation();
        public ComponentInterface Decorate(ComponentInterface component)
        {
            _component = component;
            return this;
        }
    }
}