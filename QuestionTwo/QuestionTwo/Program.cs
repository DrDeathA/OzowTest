using System;

namespace QuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conway's Game of life";

            Console.WriteLine("Please provide the following constaints");
            Console.WriteLine("Please ensure that all values are int!\n");
            Console.WriteLine("Board width");
            int boardWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("Board height");
            int boardHeight = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of generations");
            int generations = int.Parse(Console.ReadLine());

            ConwayGameOfLife cgol = new ConwayGameOfLife(boardWidth, boardHeight, generations);
            cgol.StartGameOfLife();
        }
    }
}
