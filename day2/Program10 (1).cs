using System;
					
public class Program10
{
	public static void Main()
	{
		String name;
		int age;
		String Gender;

		Console.Write("Enter your name\n");
		name = Console.ReadLine();

		Console.Write("Enter your age\n");
		age = Convert.ToInt32(Console.ReadLine());


		Console.WriteLine("Enter your gender (Male/Female)");
		Gender = Convert.ToString(Console.ReadLine());


		switch(Gender)
		{

		case "Male":Console.WriteLine ("hi Mr. {0} you are {1} years old, ",name,age);
		break;

		case "Female":Console.WriteLine("hi Miss. {0} you are {1} years old, ",name,age);
		break;

		default:Console.WriteLine("Unspecified Gender");
		break;
		}
			}
}