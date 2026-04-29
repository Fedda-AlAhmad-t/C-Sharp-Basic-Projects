using System;

/* Author: Shipping App Developer
   Purpose: Calculate shipping costs based on weight and dimensions.
   Logic: Total dimensions cannot exceed 50; Weight cannot exceed 50.
*/

namespace PackageExpressV1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial greeting required by specifications
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Step 1: Handle Weight
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            // Weight constraint check
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Ends the program execution
            }

            // Step 2: Gather Dimensions
            Console.WriteLine("Please enter the package width:");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            // Step 3: Size constraint check (Sum of dimensions)
            int dimensionTotal = pkgWidth + pkgHeight + pkgLength;

            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Terminate if size limit exceeded
            }

            // Step 4: Quote Calculation
            // Formula: (Width * Height * Length * Weight) / 100
            decimal productValue = (decimal)(pkgWidth * pkgHeight * pkgLength * packageWeight);
            decimal finalQuote = productValue / 100m;

            // Step 5: Output result formatted as currency
            Console.WriteLine("Your estimated total for shipping this package is: $" + finalQuote.ToString("F2"));
            Console.WriteLine("Thank you!");
            
            // Keep console open
            Console.ReadLine();
        }
    }
}
