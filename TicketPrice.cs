using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        double price;

        if (age <= 12 || age >= 65)
        {
            price = 7.0;
        }
        else
        {
            price = 10.0;
        }

        Console.WriteLine($"Your ticket price is: GHC{price}");
    }
}
