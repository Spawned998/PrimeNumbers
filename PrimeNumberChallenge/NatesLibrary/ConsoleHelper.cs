using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatesConsoleLibrary
{
    public static class ConsoleHelper
    {
        public static int GetUserInt(string message, int lowerLimit = int.MinValue, int upperLimit = int.MaxValue)
        {
            bool isValidInt = false;
            bool isInRange = false;
            string userInput;
            int output = 0;

            while (isValidInt == false || isInRange == false)
            {
                Console.Write($"{message}");

                userInput = Console.ReadLine();

                if(userInput == "q")
                {
                    output = -1;
                    return output;
                }

                isValidInt = int.TryParse(userInput, out output);

                if (isValidInt == true)
                {
                    isInRange = IntegerRangeCheck(output, lowerLimit, upperLimit);

                    if(isInRange == false)
                    {
                        Console.WriteLine($"Integer value must be between {lowerLimit} and {upperLimit}");
                    }
                }
            }

            return output;
        }

        public static bool IntegerRangeCheck(int integerToCheck, int lowerLimit, int upperLimit)
        {
            return integerToCheck >= lowerLimit && integerToCheck <= upperLimit;
        }


        public static void DisplayIntList(List<int> ints, string message)
        {
            Console.Write(message);

            foreach (int item in ints)
            {
                Console.Write($"\t{item}");
            }

            Console.WriteLine();
        }

    }
}
