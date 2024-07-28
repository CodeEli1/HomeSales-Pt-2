using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] salespersons = { "Danielle", "Edward", "Francis" };
        char[] initials = { 'D', 'E', 'F' };
        double[] totalSales = new double[3];
        double grandTotal = 0;
        int highestIndex = 0;

        while (true)
        {
            Console.WriteLine("Enter salesperson's initial (D, E, or F). Enter Z to quit.");
            char inputInitial = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (inputInitial == 'Z')
            {
                break;
            }

            int salespersonIndex = Array.IndexOf(initials, inputInitial);
            if (salespersonIndex == -1)
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again.");
                continue;
            }

            Console.WriteLine("Enter the amount of the sale: ");
            if (!double.TryParse(Console.ReadLine(), out double saleAmount))
            {
                Console.WriteLine("Error, invalid sale amount, please try again.");
                continue;
            }

            totalSales[salespersonIndex] += saleAmount;
            grandTotal += saleAmount;

            if (totalSales[salespersonIndex] > totalSales[highestIndex])
            {
                highestIndex = salespersonIndex;
            }
        }

        Console.WriteLine($"Total sales by {salespersons[0]}: {totalSales[0]:C}");
        Console.WriteLine($"Total sales by {salespersons[1]}: {totalSales[1]:C}");
        Console.WriteLine($"Total sales by {salespersons[2]}: {totalSales[2]:C}");
        Console.WriteLine($"Grand Total: {grandTotal:C}");
        Console.WriteLine($"Highest Sale: {salespersons[highestIndex]} with {totalSales[highestIndex]:C}");
    }
}