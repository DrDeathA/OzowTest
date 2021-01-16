using System;
using System.Linq;
using System.Text;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide with some random input");
            var inputString = Console.ReadLine();

            var workString = InputStringHandler.ToLowercase(inputString);
            workString = InputStringHandler.RemovePunctuation(workString);
            workString = InputStringHandler.RemoveWhitespces(workString);

            Console.WriteLine(InputStringHandler.Sort(workString));
        }
    }
}
