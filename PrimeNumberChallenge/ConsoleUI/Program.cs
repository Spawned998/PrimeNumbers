// See https://aka.ms/new-console-template for more information

using static ConsoleUI.ProgramSettings;
using NatesMathLibrary;
using NatesConsoleLibrary;

int userInt;
int largestFactorial;
bool isPrime;
List<int> primeFactorials;
List<int> factorialList;
List<int> allPrimeNumbers;

allPrimeNumbers = PrimeNumbers.GetAllPrimeNumbers(500);

ConsoleHelper.DisplayIntList(allPrimeNumbers, "Prime Numbers: ");

Console.WriteLine();

userInt = ConsoleHelper.GetUserInt("Please enter an integer: ", MinValue, MaxValue);

do
{
    isPrime = PrimeNumbers.CheckIfPrime(userInt);


    if (isPrime)
    {
        Console.WriteLine($"{userInt} is a prime number.");
    }
    else
    {
        factorialList = PrimeNumbers.GetAllFactors(userInt);

        primeFactorials = PrimeNumbers.GetAllPrimeFactors(factorialList);

        largestFactorial = PrimeNumbers.GetLargestFactorial(primeFactorials);

        ConsoleHelper.DisplayIntList(factorialList, "Unique factors: ");

        ConsoleHelper.DisplayIntList(primeFactorials, "Unique prime factors: ");

        Console.WriteLine($"Largest prime factorial: {largestFactorial}");
    }

    userInt = ConsoleHelper.GetUserInt("Please enter an integer(q to quit): ", MinValue, MaxValue);
}
while (userInt != -1);
