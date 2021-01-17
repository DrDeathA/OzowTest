using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QuestionTwo.UnitTests
{
    [TestClass]
    public class GameOfLifeTests
    {
        ConwayGameOfLife cgolTest;

        [TestMethod]
        public void LivingNeigbourCounterTest()
        {
            cgolTest = new ConwayGameOfLife(2, 2);
            cgolTest.CurrentIteration[0, 1] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[1, 0] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[1, 1] = cgolTest.livingCellRep;

            var result = cgolTest.LivingNeighbourCounter(0, 0);

            Assert.IsTrue(result == 3);
        }

        [TestMethod]
        public void DeadCellWithZeroLivingNeighbourTest()
        {
            cgolTest = new ConwayGameOfLife(2, 2);
            cgolTest.CurrentIteration[1, 1] = cgolTest.livingCellRep;
            cgolTest.RuleImplementation(1, 1, cgolTest.LivingNeighbourCounter(1, 1));
            Array.Copy(cgolTest.NextIteration, cgolTest.CurrentIteration, cgolTest.BoardWidth * cgolTest.BoardHeight);

            var result = cgolTest.LivingNeighbourCounter(0, 0);

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void LivingCellWithOneLivingNeighbourTest()
        {
            cgolTest = new ConwayGameOfLife(3, 3);
            cgolTest.CurrentIteration[1, 1] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[2, 2] = cgolTest.livingCellRep;
            cgolTest.RuleImplementation(1, 1, cgolTest.LivingNeighbourCounter(1, 1));
            Array.Copy(cgolTest.NextIteration, cgolTest.CurrentIteration, cgolTest.BoardWidth * cgolTest.BoardHeight);

            var result = cgolTest.LivingNeighbourCounter(0, 0);

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void LivingCellWithFourLivingNeighboursTest()
        {
            cgolTest = new ConwayGameOfLife(3, 3);
            cgolTest.CurrentIteration[1, 1] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[0, 1] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[0, 2] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[1, 2] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[2, 2] = cgolTest.livingCellRep;
            Array.Copy(cgolTest.CurrentIteration, cgolTest.NextIteration, cgolTest.BoardWidth * cgolTest.BoardHeight);
            cgolTest.RuleImplementation(1, 1, cgolTest.LivingNeighbourCounter(1, 1));
            Array.Copy(cgolTest.NextIteration, cgolTest.CurrentIteration, cgolTest.BoardWidth * cgolTest.BoardHeight);

            var result = cgolTest.LivingNeighbourCounter(1, 1);

            Assert.IsTrue(result == 4);
        }

        [TestMethod]
        public void LivingCellWithFiveLivingNeighboursTest()
        {
            cgolTest = new ConwayGameOfLife(3, 3);
            cgolTest.CurrentIteration[1, 1] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[0, 1] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[0, 2] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[1, 2] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[2, 2] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[2, 1] = cgolTest.livingCellRep;
            Array.Copy(cgolTest.CurrentIteration, cgolTest.NextIteration, cgolTest.BoardWidth * cgolTest.BoardHeight);
            cgolTest.RuleImplementation(1, 1, cgolTest.LivingNeighbourCounter(1, 1));
            Array.Copy(cgolTest.NextIteration, cgolTest.CurrentIteration, cgolTest.BoardWidth * cgolTest.BoardHeight);

            var result = cgolTest.LivingNeighbourCounter(1, 1);

            Assert.IsTrue(result == 5);
        }

        [TestMethod]
        public void DeadCellWithThreeLivingNeighboursTest()
        {
            cgolTest = new ConwayGameOfLife(3, 3);
            cgolTest.CurrentIteration[1, 1] = cgolTest.deadCellRep;
            cgolTest.CurrentIteration[0, 1] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[0, 2] = cgolTest.livingCellRep;
            cgolTest.CurrentIteration[1, 2] = cgolTest.livingCellRep;
            Array.Copy(cgolTest.CurrentIteration, cgolTest.NextIteration, cgolTest.BoardWidth * cgolTest.BoardHeight);
            cgolTest.RuleImplementation(1, 1, cgolTest.LivingNeighbourCounter(1, 1));
            Array.Copy(cgolTest.NextIteration, cgolTest.CurrentIteration, cgolTest.BoardWidth * cgolTest.BoardHeight);

            var result = cgolTest.LivingNeighbourCounter(1, 1);

            Assert.IsTrue(cgolTest.CurrentIteration[1, 1] == cgolTest.livingCellRep);
        }

        [TestMethod]
        public void RandomPopulatorTester()
        {
            cgolTest = new ConwayGameOfLife(3, 3);
            cgolTest.RadomBoardFiller();

            var counter = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    var item = cgolTest.CurrentIteration[i, j];
                    if(item.CompareTo(cgolTest.livingCellRep) == 0 || item.CompareTo(cgolTest.deadCellRep) == 0)
                    {
                        counter++;
                    }
                }
            }

            Assert.IsTrue(counter == 9);
        }
    }
}
