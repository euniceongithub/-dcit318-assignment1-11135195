using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter side 1: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double side3 = double.Parse(Console.ReadLine());

        // Check for valid triangle
        if (side1 <= 0 || side2 <= 0 || side3 <= 0 ||
            (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1))
        {
            Console.WriteLine("Invalid triangle.");
        }
        else if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Triangle type: Equilateral");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("Triangle type: Isosceles");
        }
        else
        {
            Console.WriteLine("Triangle type: Scalene");
        }
    }
}
