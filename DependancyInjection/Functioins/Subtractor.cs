using System;

namespace DependancyInjection.Functions
{
    public class Subtractor : ISubtractor
    {
        public int Subtract(int firstNum, int secondNum)
        {
            var total = firstNum - secondNum;
            Console.WriteLine($"The subtraction of {firstNum} and {secondNum} is {total}");
            return total;
        }
    }
}
