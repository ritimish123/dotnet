public class Program3
    {
	   public static decimal calculateTax(decimal amount, decimal tax){
		   return amount+(amount*tax);
	   }
	   
         public static void Main(string []args)
                {
                  
			 decimal amount, tax;
				
			  Console.Write("Enter amount: ");
            amount = decimal.Parse(Console.ReadLine());
			   Console.Write("Enter tax: ");
            tax = decimal.Parse(Console.ReadLine());
			 Console.Write("Total Tax: {0}",calculateTax(amount,tax));
			
			 
			
			 }
		     
                }