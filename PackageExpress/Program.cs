using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the initial welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            // Read the user's input, convert it to a double, and store it in the 'weight' variable
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the entered weight is greater than the maximum limit of 50
            if (weight > 50)
            {
                // If it is too heavy, display this error message
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // Exit the program immediately
                return;
            }

            // Prompt the user to enter the package width
            Console.WriteLine("Please enter the package width:");
            // Read the user's input, convert it to a double, and store it in the 'width' variable
            double width = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the package height
            Console.WriteLine("Please enter the package height:");
            // Read the user's input, convert it to a double, and store it in the 'height' variable
            double height = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the package length
            Console.WriteLine("Please enter the package length:");
            // Read the user's input, convert it to a double, and store it in the 'length' variable
            double length = Convert.ToDouble(Console.ReadLine());

            // Add the width, height, and length together to get the total dimensions
            double totalDimensions = width + height + length;

            // Check if the total dimensions exceed the maximum limit of 50
            if (totalDimensions > 50)
            {
                // If the package is too big, display this error message
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // Exit the program immediately
                return;
            }

            // Multiply the three dimensions together, multiply by weight, and divide by 100 to get the quote
            double quote = (height * width * length * weight) / 100;

            // Display the final quote formatted as a dollar amount with two decimal places
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");

            // Display a final thank you message
            Console.WriteLine("Thank you!");
        }
    }
}