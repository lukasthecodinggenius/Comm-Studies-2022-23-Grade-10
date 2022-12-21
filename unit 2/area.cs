using System;

class Program
{
  public static void Main(string[] args)
  {
    int radius=6; //declaration
    double area;
    const double pi=3.14;

    radius=5; //initialization
    area= pi*radius*radius;

    int radius1=8; 
    double area1;
    area1 = pi*radius1*radius1;

    Console.WriteLine ("Area is "+area);
Console.WriteLine("Area is "+area1);
        }
    
}
