using System;

class Program
{
 public static void Main(string[] args)	
 {
Console.WriteLine("Welcome to trivia, try your best to answer the questions:");

Console.WriteLine("Question - What is lukas's last name?");

Console.WriteLine("1. Munch");
Console.WriteLine("2. Muench");
Console.WriteLine("3. Menuch");
Console.WriteLine("4. James");

	string answer1;
	answer1 = Console.ReadLine();

	 if(answer1=="Muench") {
		 Console.WriteLine("Correct!");
	 } else {
		 Console.WriteLine("Incorrect");
	 }
	Console.WriteLine("Question 2 - What is lukas's favourite food?");

	 Console.WriteLine("1. Spaghetti");
	  Console.WriteLine("2. Tacos");
	  Console.WriteLine("3. Chicken Wings");
	  Console.WriteLine("4. KitKat");

string answer2;
	answer2 = Console.ReadLine();

	 if(answer2=="Spaghetti") {
		 Console.WriteLine("Correct");
	 } else {
		 Console.WriteLine("Incorrect");
	 }
	 Console.WriteLine("Question 3. What is 5+2?");

	 Console.WriteLine("1. 7");
	 Console.WriteLine("2. 6");
	 Console.WriteLine("3. 8");
	 Console.WriteLine("4. 130");

string answer3;
	 answer3 = Console.ReadLine();

	if(answer3=="1") {
		Console.WriteLine("Correct");
	} else {
		Console.WriteLine("Incorrect");
	}
	 Console.WriteLine("Last Question: How many fingers does a human have?");

	 Console.WriteLine("1. 11");
	 Console.WriteLine("2. 6");
	 Console.WriteLine("3. 9");
	 Console.WriteLine("4. 10");

	 string answer4;
		 answer4 = Console.ReadLine();

	 if(answer4=="10") {
		 Console.WriteLine("Correct");
	 } else {
		 Console.WriteLine("Incorrect");
	 }
 }
}



	
							
