using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QuestionOne
{
    public static class InputStringHandler
    {
        public static string ToLowercase(string inputString)
        {
            return inputString.ToLower();
        }


        public static string RemoveWhitespces(string inputStreing)
        {
            //regex that replaces all white spaces
            return Regex.Replace(inputStreing, @"\s", "");
        }

        public static string RemovePunctuation(string inputString)
        {
            //Regex that replaces any non-word-character with an empty string
            return Regex.Replace(inputString, @"[^\w]", "");
        }

        public static string Sort(string inputString)
        {
            StringBuilder sortedString = new StringBuilder();
            StringBuilder stackA = new StringBuilder();
            StringBuilder stackB = new StringBuilder();
            StringBuilder stackC = new StringBuilder();
            StringBuilder stackD = new StringBuilder();
            StringBuilder stackE = new StringBuilder();
            StringBuilder stackF = new StringBuilder();
            StringBuilder stackG = new StringBuilder();
            StringBuilder stackH = new StringBuilder();
            StringBuilder stackI = new StringBuilder();
            StringBuilder stackJ = new StringBuilder();
            StringBuilder stackK = new StringBuilder();
            StringBuilder stackL = new StringBuilder();
            StringBuilder stackM = new StringBuilder();
            StringBuilder stackN = new StringBuilder();
            StringBuilder stackO = new StringBuilder();
            StringBuilder stackP = new StringBuilder();
            StringBuilder stackQ = new StringBuilder();
            StringBuilder stackR = new StringBuilder();
            StringBuilder stackS = new StringBuilder();
            StringBuilder stackT = new StringBuilder();
            StringBuilder stackU = new StringBuilder();
            StringBuilder stackV = new StringBuilder();
            StringBuilder stackW = new StringBuilder();
            StringBuilder stackX = new StringBuilder();
            StringBuilder stackY = new StringBuilder();
            StringBuilder stackZ = new StringBuilder();

            //Looping through string and placing each char on their stack that will be combined into "sortedString"
            for(int i = 0; i < inputString.Length; i++)
            {
                switch(inputString[i])
                {
                    case 'a':
                        stackA.Append(inputString[i]);
                        break;
                    case 'b':
                        stackB.Append(inputString[i]);
                        break;
                    case 'c':
                        stackC.Append(inputString[i]);
                        break;
                    case 'd':
                        stackD.Append(inputString[i]);
                        break;
                    case 'e':
                        stackE.Append(inputString[i]);
                        break;
                    case 'f':
                        stackF.Append(inputString[i]);
                        break;
                    case 'g':
                        stackG.Append(inputString[i]);
                        break;
                    case 'h':
                        stackH.Append(inputString[i]);
                        break;
                    case 'i':
                        stackI.Append(inputString[i]);
                        break;
                    case 'j':
                        stackJ.Append(inputString[i]);
                        break;
                    case 'k':
                        stackK.Append(inputString[i]);
                        break;
                    case 'l':
                        stackL.Append(inputString[i]);
                        break;
                    case 'm':
                        stackM.Append(inputString[i]);
                        break;
                    case 'n':
                        stackN.Append(inputString[i]);
                        break;
                    case 'o':
                        stackO.Append(inputString[i]);
                        break;
                    case 'p':
                        stackP.Append(inputString[i]);
                        break;
                    case 'q':
                        stackQ.Append(inputString[i]);
                        break;
                    case 'r':
                        stackR.Append(inputString[i]);
                        break;
                    case 's':
                        stackS.Append(inputString[i]);
                        break;
                    case 't':
                        stackT.Append(inputString[i]);
                        break;
                    case 'u':
                        stackU.Append(inputString[i]);
                        break;
                    case 'v':
                        stackV.Append(inputString[i]);
                        break;
                    case 'w':
                        stackW.Append(inputString[i]);
                        break;
                    case 'x':
                        stackX.Append(inputString[i]);
                        break;
                    case 'y':
                        stackY.Append(inputString[i]);
                        break;
                    case 'z':
                        stackZ.Append(inputString[i]);
                        break;
                    default:
                        break;
                }
            }
            sortedString.Append(stackA.ToString() + stackB.ToString() + stackC.ToString() + stackD.ToString() + stackE.ToString() + stackF.ToString() + stackG.ToString() +
                stackH.ToString() + stackI.ToString() + stackJ.ToString() + stackK.ToString() + stackL.ToString() + stackM.ToString() + stackN.ToString() + stackO.ToString() +
                stackP.ToString() + stackQ.ToString() + stackR.ToString() + stackS.ToString() + stackT.ToString() + stackU.ToString() + stackV.ToString() + stackW.ToString() +
                stackX.ToString() + stackY.ToString() + stackZ.ToString());
            return sortedString.ToString();
        }
    }
}
