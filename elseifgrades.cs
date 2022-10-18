using System;      
public class Program
    {  
        public static void Main(string[] args)  
        {  
            Console.WriteLine("Enter your grade here please! - ");  
            int num = Convert.ToInt32(Console.ReadLine());  
  
            if (num <0 || num >100)  
            {  
                Console.WriteLine("this is not possible make sure the grade is in between 0 and 100 please");  
            }  
    else if(num >= 0 && num < 50){  
 Console.WriteLine("you failed try again next time");  
    }  
   else if (num >= 50 && num < 60)  
   {  
     Console.WriteLine("you got a d");  
  }  
    else if (num >= 60 && num < 70)  
  {  
 Console.WriteLine("you got a c study better");  
 }  
    else if (num >= 70 && num < 80)  
            {  
                Console.WriteLine("you got a B, decent");  
            }  
     else if (num >= 80 && num < 90)  
            {  
    Console.WriteLine("you got an A your insane");  
            }  
     else if (num >= 90 && num <= 100)  
            {  
   Console.WriteLine("wow your a smart person you got an a plus ");  
            }  
        }  
    }  
        
