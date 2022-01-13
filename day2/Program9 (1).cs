using System;  
public class Program9
{  
    public static void Main()
{
    int num,i,ctr,stno,enno;
	
	
    Console.Write("prime numbers between a maximum and minimum number :\n");
    Console.Write("Minimum number : ");
    stno = Convert.ToInt32(Console.ReadLine()); 	
    Console.Write("Maximum number  : ");
    enno = Convert.ToInt32(Console.ReadLine()); 	
    Console.Write("The prime numbers between {0} and {1} are : \n",stno,enno);
  
    for(num = stno;num<=enno;num++)
       {
         ctr = 0;

         for(i=2;i<=num/2;i++)
            {
             if(num%i==0){
                 ctr++;
                 break;
             }
        }
        
         if(ctr==0 && num!= 1)
             Console.Write("{0} ",num);
    }
    Console.Write("\n"); 
  } 
}