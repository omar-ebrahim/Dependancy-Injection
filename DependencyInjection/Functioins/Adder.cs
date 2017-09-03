using System;

namespace DependencyInjection.Functions
{
    public class Adder : IAdder
    {
        public int Add(int firstNum, int secondNum)
        {
            var total = firstNum + secondNum;
            Console.WriteLine($"The addition of {firstNum} and {secondNum} is {total}");
            return total;
        }
    }
}
