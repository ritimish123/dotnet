using System;
					
public class Program7
{
	public static float xyz(int[] s)
	{
		float avg=0;
		int x=0;
		for(int i=0;i<15;i++)
		{
			if(s[i]%7==0)
			{
				avg=avg+s[i];
				x++;
			}
		}
		avg=avg/x;
		Console.WriteLine(avg);
		
		return avg;
	}
	
	public static void Main()
	{
		int i;
		float sum=0;
		int[] arr= new int[15];
		for(i=0;i<15;i++)
		{
			Console.WriteLine("enter the {0} value,",i);
			arr[i]= Convert.ToInt16(Console.ReadLine());
				
		}
	
			sum=xyz(arr);
			Console.WriteLine("Average is {0},",sum);

	}
}