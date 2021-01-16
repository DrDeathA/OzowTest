using System;
using System.Threading;

namespace QuestionTwo
{
    public class ConwayGameOfLife
    {
        public int BoardWidth { get; set; }
        public int BoardHeight { get; set; }
        public int Generations { get; set; }

        //Cell representation
        public char livingCellRep = '*';
        public char deadCellRep = ' ';

        //Console colouring
        private ConsoleColor backColour = ConsoleColor.Black;
        private ConsoleColor livingCellColour = ConsoleColor.Magenta;

        public char[,] CurrentIteration { get; set; } //the current visable iteration
        public char[,] NextIteration { get; set; } //the next iteration that will be visable

        Random random;

        //Game play entry point
        public ConwayGameOfLife(int boardWidth, int boardHeight, int generations)
        {
            BoardWidth = boardWidth;
            BoardHeight = boardHeight;
            Generations = generations;

            CurrentIteration = new char[boardWidth, boardHeight];
            NextIteration = new char[boardWidth, boardHeight];

            //Console setup
            ConsoleSetup();

            //Sets default board
            RadomBoardFiller();
        }

        //Test entry point
        public ConwayGameOfLife(int boardWidth, int boardHeight)
        {
            BoardWidth = boardWidth;
            BoardHeight = boardHeight;

            CurrentIteration = new char[boardWidth, boardHeight];
            NextIteration = new char[boardWidth, boardHeight];
        }

        //Console controles
        public void ConsoleSetup()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(BoardWidth, BoardHeight);
            Console.SetBufferSize(BoardWidth, BoardHeight);
            Console.BackgroundColor = backColour;
            Console.ForegroundColor = livingCellColour;
        }

        //Manages the drawing the current iteration
        public void IterationDrawer()
        {
            for(int i = 0; i < BoardWidth; i++)
            {
                for(int j = 0; j < BoardHeight; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(CurrentIteration[i, j]);  
                }
            }
        }

        public void StartGameOfLife()
        {
            var generation = 0;

            while(generation < Generations)
            {
                generation++;
                Console.Title = $"Generation {generation}/{Generations}";
                Array.Copy(CurrentIteration, NextIteration, BoardHeight * BoardWidth);

                IterationDrawer();

                for(int i = 0; i < BoardWidth; i++)
                {
                    for(int j = 0; j < BoardHeight; j++)
                    {

                        RuleImplementation(i, j, LivingNeighbourCounter(i, j));

                    }
                }

                Array.Copy(NextIteration, CurrentIteration, BoardWidth * BoardHeight);
                Thread.Sleep(15);
            }
        }

        public int LivingNeighbourCounter(int row, int column)
        {
            var livingNeighbour = 0;

            for(int k = -1; k < 2; k++)
            {
                for(int l = -1; l < 2; l++)
                {
                    //k & l == 0 ensures to only return the neighbours
                    //further ensures the loop remains within index ranges
                    if(!(k == 0 && l == 0) && ((row + k >= 0 && row + k < BoardWidth) &&
                        (column + l >= 0 && column + l < BoardHeight)))
                    {
                        //validates living cell
                        if(CurrentIteration[row + k, column + l] == livingCellRep)
                        {
                            livingNeighbour++;
                        }
                    }
                }
            }

            return livingNeighbour;
        }

        public void RuleImplementation(int row, int column, int livingCells)
        {
            //Validats the rules stating if a living cell has one or less neihbour and 4 or more neighbours
            if(CurrentIteration[row, column] == livingCellRep && (livingCells >= 4 || livingCells <= 1))
            {
                NextIteration[row, column] = deadCellRep;
            }
            //validates to resurrect dead cells if it has 3 living neighbours
            else if(CurrentIteration[row, column] == deadCellRep && livingCells == 3)
            {
                NextIteration[row, column] = livingCellRep;
            }
        }

        public void RadomBoardFiller()
        {
            random = new Random();
            for(int i = 0; i < BoardWidth; i++)
            {
                for(int j = 0; j < BoardHeight; j++)
                {
                    //emsures that the board is not over populated
                    if(random.Next(10) == 0)
                    {
                        CurrentIteration[i, j] = NextIteration[i, j] = livingCellRep;
                    }
                    else
                    {
                        CurrentIteration[i, j] = NextIteration[i, j] = deadCellRep;
                    }
                }
            }
        }
    }
}
