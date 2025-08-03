using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Movie Ticket Price Calculator ===");
            Console.WriteLine("Enter your age:");
            
            try
            {
                // Read user input and convert to integer
                string input = Console.ReadLine();
                int age = Convert.ToInt32(input);
                
                // Validate input
                if (age < 0)
                {
                    Console.WriteLine("Error: Age cannot be negative.");
                    return;
                }
                
                // Calculate ticket price based on age
                decimal ticketPrice;
                string category;
                
                if (age <= 12)
                {
                    ticketPrice = 7.00m;
                    category = "Child";
                }
                else if (age >= 65)
                {
                    ticketPrice = 7.00m;
                    category = "Senior Citizen";
                }
                else
                {
                    ticketPrice = 10.00m;
                    category = "Regular";
                }
                
                // Display result
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Category: " + category);
                Console.WriteLine("Ticket Price: GHC" + ticketPrice.ToString("F2"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid age (whole number).");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
