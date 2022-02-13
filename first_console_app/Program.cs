using System;

namespace first_console_app
{
    internal class Program
    {
        const int MAXVALUE = 999999999;
        const int MINVALUE = 0;
        private static int GenerateRandomNumber()
        {
            return new Random().Next(MINVALUE, MAXVALUE);
        }

        private static bool IsInputAndRandomNumbersEqual(int randomNumber, int inputNumber)
        {
            if (randomNumber != inputNumber) return false;

            return true;
        }

        private static int GetInputNumber()
        {
            Console.Write($"Type a number between {MINVALUE} and {MAXVALUE}: ");
            int inputNumber = int.Parse(Console.ReadLine());

            return inputNumber;
        }

        private static void ValidateData(bool isEqual, int randomNumber, int inputNumber)
        {
            if (isEqual) Console.WriteLine("\n- Congratulations, the typed number is equal to the random number.");
            else
            {
                Console.WriteLine("\n- Whoops, the typed number is not equal to the random number.");

                if (inputNumber < randomNumber) Console.WriteLine("- The input number is smaller than random number.\n");
                else Console.WriteLine("- The input number is greater than random number.\n");

                Console.WriteLine($"The random number was {randomNumber}");
            }
        }

        private static void ReturnResponse()
        {
            int randomNumber = GenerateRandomNumber();
            int inputNumber = GetInputNumber();
            bool isEqual = IsInputAndRandomNumbersEqual(randomNumber, inputNumber);

            ValidateData(isEqual, randomNumber, inputNumber);
        }
        private static void Main()
        {
            ReturnResponse();
        }

    }
}
