using System;
using System.Runtime.InteropServices.ComTypes;

namespace AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 0;
            do
            {
                Console.WriteLine("Enter the radius of your circle:");
                radius = double.Parse(Console.ReadLine());
            } while (radius <= 0);
            
            double area = Math.PI * Math.Pow(radius, 2.0);
            double circumference = 2 * Math.PI * radius;
            double diameter = 2 * radius;
            Console.WriteLine("The area of a circle with the radius " + radius.ToString() + " is: " + area.ToString());
            Console.WriteLine("The circumference of a circle with the radius " + radius.ToString() + " is: " + circumference.ToString());
            Console.WriteLine("The diameter of a circle with the radius " + radius.ToString() + " is: " + diameter.ToString());

            Console.WriteLine("How many miles per gallon does your car get?");
            double milesPerGallon = double.Parse(Console.ReadLine());
            Console.WriteLine("Was the radius entered earlier in miles?(yes/no)");
            string answer = Console.ReadLine();
            if(answer.ToLower() == "yes") {
                double numberOfGallons = circumference / milesPerGallon;
                Console.WriteLine("You would burn " + numberOfGallons + " gallons of gasoline traveling around the circle.");
            }
            else
            {
                Console.WriteLine("Have a nice day!");
            }
        }
    }
}
