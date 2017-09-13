
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace theRealAreaCalculator
{
	/// <summary>
	/// Quick and easy program to compute the circumference and area of a circle
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			// Prompt the user for a the sides of the triangle.
			Console.Write("Give me sides a, b, and c of yo triangle:  \n");

            // The user will type a number and that must be converted into
            // a type double because the ReadLine method returns a String.
            Console.WriteLine("a = ");
			double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c = "); 
            double c = Convert.ToDouble(Console.ReadLine());

            // This computes the perimeter and area
            double s = ((a + b + c) / 2);
            double perimeter = (a + b + c);
            double area = (s * (s-a) * (s-b) * (s-c));

            //this tells you whether its a triangle
            if (area > 0)
            {
                area = Math.Sqrt(area);
                Console.WriteLine("The perimeter is {0}\nThe area is {1}", perimeter, area);
                Console.ReadKey();
            }
            // this prints if its not a triangle
            else
            {
                Console.WriteLine("Not a Triangle");
                Console.ReadKey();
            }
           }
	}
}