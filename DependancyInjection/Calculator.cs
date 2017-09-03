using DependancyInjection.Functions;
using DependancyInjection.Handlers;
using Ninject;
using System;
using System.Reflection;

namespace DependancyInjection
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            /*
             * Because we can't use anything injected because it's not static,
             * I've got Ninject to do it for me manually.
             * This would normally be called in App_Start somewhere, if in a web project.
             */
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            Console.WriteLine();
            Console.WriteLine("Adder example");
            Console.WriteLine();

            var adder = kernel.Get<IAdder>();
            adder.Add(1, 2);
            adder.Add(5, 5);

            Console.WriteLine();
            Console.WriteLine("Handler example");
            Console.WriteLine();

            /*
             * Below is an example of why it's useful.
             * I created a handler that takes both IAdder annd ISubtractor in the constructor.
             * Without Ninject I'd have to create both concrete implementations of the adder and subtractor
             * and pass them as parameters in the constructor when instantiating the handler
             */
            var handler = kernel.Get<IHandler>();
            handler.Handle(1, 2);
            handler.Handle(5, 5);

            Console.ReadLine();
        }
    }
}
