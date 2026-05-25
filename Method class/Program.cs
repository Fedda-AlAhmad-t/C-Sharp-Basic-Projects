using System;    // 🌐 Brings in the System namespace so we can use Console and other basic functionality.

namespace DemoConsoleApp
{
    // 🧱 This class holds our custom method as described in the requirements.
    class MathOperations
    {
        /* 
         * 🛠️ Void method that takes two integers.
         * It performs a math operation (we'll square the first number),
         * AND displays the second number to the screen.
         */
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // 🎯 Perform a math operation on the first number.
            int result = firstNumber * firstNumber;   // Squaring for demonstration.

            // 📣 Display the result of the math operation.
            Console.WriteLine($"The square of {firstNumber} is: {result}");

            // 📣 Also output the second integer as instructed.
            Console.WriteLine($"The second number provided is: {secondNumber}");
        }
    }

    class Program
    {
        // 🚪 Main entry point of the console app — execution starts here.
        static void Main(string[] args)
        {
            // 🧩 Instantiate the class so we can call its method.
            MathOperations ops = new MathOperations();

            // 🔔 Call the method using regular positional arguments.
            ops.ProcessNumbers(5, 20);

            // 🔔 Call the method again, this time using named parameters.
            ops.ProcessNumbers(firstNumber: 7, secondNumber: 99);

            // 🧹 Pause the console so the user can read the output before it closes.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
