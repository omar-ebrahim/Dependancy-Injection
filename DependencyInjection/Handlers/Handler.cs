using DependencyInjection.Functions;

namespace DependencyInjection.Handlers
{
    public class Handler : IHandler
    {
        private readonly IAdder adder;
        private readonly ISubtractor subtractor;

        public Handler(IAdder adder, ISubtractor subtractor)
        {
            this.adder = adder;
            this.subtractor = subtractor;
        }

        public void Handle(int firstNum, int secondNum)
        {
            adder.Add(firstNum, secondNum);
            subtractor.Subtract(firstNum, secondNum);
        }
    }
}
