// GUESS the word “HELP”

// Accept a word from the user and say whether it is correct….If its not correct give the user the count of  matching letters and location 

// LIKE
// 0 Bulls 1 Cows  --If you find matching letter in Exact Location you will show ascount of Bulls
// If the letter is matching but not in the same location then Cows
// HIRE
// 1	Bulls 1 Cows
// ***********************************************************************************************************************



using System;
public class Program
{
	public static void Main(string[] args)
	{
		string word="HELP";
		char[] wordchar=word.ToCharArray();
		Console.WriteLine("Enter your word:");
		string guessword = Console.ReadLine();
		char[] guesschar=guessword.ToCharArray();
		int cowcount=0,bullcount=0;
		if(word.Equals(guessword))
		{
			Console.WriteLine("Word match");
			return;
		}
		if(wordchar.Length==guesschar.Length)
		{
		for(int i=0;i<wordchar.Length;i++)
		{
		if(wordchar[i]==guesschar[i])
		{
		bullcount++;
		}
		else
		{
		for(int j=i;j<wordchar.Length;j++)
		{
		if(wordchar[i]==guesschar[j])
		{
		cowcount++;
		break;
		}
		}
		}
		}
		}
		Console.WriteLine("Bull count:{0}",bullcount);
		Console.WriteLine("Cow count:{0}",cowcount);
	}
}