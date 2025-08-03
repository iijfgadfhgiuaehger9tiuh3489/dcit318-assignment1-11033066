using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Triangle Type Identifier ===");
            Console.WriteLine("Enter the three sides of a triangle:");
            
            try
            {
                // Read the three sides
                Console.Write("Enter first side: ");
                string input1 = Console.ReadLine();
                double side1 = Convert.ToDouble(input1);
                
                Console.Write("Enter second side: ");
                string input2 = Console.ReadLine();
                double side2 = Convert.ToDouble(input2);
                
                Console.Write("Enter third side: ");
                string input3 = Console.ReadLine();
                double side3 = Convert.ToDouble(input3);
                
                // Validate that all sides are positive
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                {
                    Console.WriteLine("Error: All sides must be positive numbers.");
                    return;
                }
                
                // Validate that the sides can form a triangle (triangle inequality)
                if (!IsValidTriangle(side1, side2, side3))
                {
                    Console.WriteLine("Error: These sides cannot form a valid triangle.");
                    Console.WriteLine("The sum of any two sides must be greater than the third side.");
                    return;
                }
                
                // Determine triangle type
                string triangleType = DetermineTriangleType(side1, side2, side3);
                
                // Display result
                Console.WriteLine("Side 1: " + side1);
                Console.WriteLine("Side 2: " + side2);
                Console.WriteLine("Side 3: " + side3);
                Console.WriteLine("Triangle Type: " + triangleType);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid numerical values for all sides.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        // Method to check if three sides can form a valid triangle
        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3) && 
                   (side1 + side3 > side2) && 
                   (side2 + side3 > side1);
        }
        
        // Method to determine the type of triangle
        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
