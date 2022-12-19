using System;

class Program 
{
	public static void Main(string[] args)
	{
	//declare the constant variable (which never changes throughout the program) followed by double because pi contains decimals
	const double pi = 3.14; 
	Console.WriteLine("What is the radius of the circle?");
	int radius;
//take input from the user using toint32 and readline
	radius = Convert.ToInt32(Console.ReadLine());
//display the area of a circle using the radius given by the user
	Console.WriteLine("The Area of this circle is: " + radius * radius * pi);
	
	}
}
