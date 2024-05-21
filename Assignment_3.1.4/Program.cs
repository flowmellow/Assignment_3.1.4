/*
Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
Test Data :
Input the value for X coordinate :7
Input the value for Y coordinate :9
Expected Output :
The coordinate point (7,9) lies in the First quadrant.
*/

namespace Assignment_3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the x and y values to find the quadrant of your point: ");
            Console.Write("Input x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y: ");
            int y = Convert.ToInt32(Console.ReadLine()); 

            if (x > 0 && y > 0) 
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            }

            if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            }

            if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            }

            if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
            Console.WriteLine();
            Console.WriteLine("Thanks for using the quadrant plotter. :) ");
        }


    }
}
