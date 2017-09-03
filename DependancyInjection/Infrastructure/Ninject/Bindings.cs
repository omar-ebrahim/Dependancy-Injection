using DependancyInjection.Functions;
using DependancyInjection.Handlers;
using Ninject.Modules;

namespace DependancyInjection.Infrastructure.Ninject
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            /*
             * In doing this, every time IAdder is in the constructor, 
             * the concrete implementation of Adder will be made
             * N.B: if the interfaces and implementations are in the same namespace
             * then it's considered good practice to bind all interfaces in the namespace of XYZ
             * (convention over configuration)
             */
            Bind<IAdder>().To<Adder>();
            Bind<ISubtractor>().To<Subtractor>();

            Bind<IHandler>().To<Handler>();
        }
    }
}
