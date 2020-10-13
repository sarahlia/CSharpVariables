using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(2, 10); //generates a random number between 2 and less than 10.
            int secondNumber = randomNumber.Next(2, 10);
            //can also do:
            var subtraction = randomNumber.Next(2, 10);

            int answer = firstNumber * secondNumber - subtraction;
            string prompt = ". Do NOT type in the answer, just press Enter when ready.";

            Console.WriteLine("Think of a number between 1 and 10" + prompt);
            Console.ReadKey(); //wait until any key is pressed.
            Console.WriteLine("Multiply your number by " + firstNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Now multiply the result by " + secondNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Divide the result by the number you originally though of" + prompt);
            Console.ReadKey();
            Console.WriteLine("Now subtract " + subtraction + prompt);
            Console.ReadKey();

            Console.WriteLine("The answer is " + answer);
        }
    }
}
