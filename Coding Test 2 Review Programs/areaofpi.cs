using System;

class Program 
{
	public static void Main(string[] args)
	{
	const double pi = 3.14; 
	Console.WriteLine("What is the radius of the circle?");
	int radius;

	radius = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("The Area of this circle is: " + radius * radius * pi);
	
	}
}
