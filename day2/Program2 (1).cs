using System;

   public class Program2
    {
         public static void Main(string []args)
                {
                  
			 decimal num,sum=0;
				do{	
			  Console.Write("Enter number: ");
            num = decimal.Parse(Console.ReadLine());
			  sum+=num;
				}
			 while(num>=0);
			 
			 Console.WriteLine("Sum of Positive Numbers :{0}",sum);
			  Console.ReadLine();
			 
			 }
		     
                }