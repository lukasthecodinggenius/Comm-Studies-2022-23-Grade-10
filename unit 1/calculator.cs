using System;      

public class Program

{
  public static void Main(string[] args)
  {
    Console.WriteLine("please enter your numbers here");
      int number1 = Convert.ToInt32(Console.ReadLine());
     int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("please enter your operator here");
    string oper = Console.ReadLine();

    switch (oper) {
      case "-": 
        Console.WriteLine(number1 - number2);
        break;
      case "+": Console.WriteLine (number1 + number2);
        break;
      case "/": Console.WriteLine(number1 / number2);
        break;
      case "*": Console.WriteLine(number1 * number2);
        break;
      case "%": Console.WriteLine(number1 % number2);
        break;
    }
  }
}
  
