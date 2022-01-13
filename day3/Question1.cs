// Write a program to create a game that implements the following features:
 	// Display the following word:
			// MASTER
 	// Ask the user to create multiple words from the letters of the given word.
 	// Display the basic instructions to play the game.
 	// The program should display “Correct” and increase the score of the user by 1, if the user enters a correct word. 
 	// The program should display “You have already entered the word: ####”, if the user enters a word repetitively.
 	// NOTE: #### stands for the word entered by the user.
 	// The program should display “Incorrect”, if the user enters a word that is not valid.
 	// The program should display the final score, if the user enters the word “QUIT”.
// ***************************************************************************************************************************





using System;
using System.Collections.Generic;


public class Program
{
	public static void Main(string[] args)
	{
		string[] words = {"armets","master","maters","matres","ramets","stream","tamers"};

		Console.WriteLine("Genearte appropriate words from MASTER\n");
		Console.WriteLine("General Instruction:\n"+
		"1. Dont repeat the word\n"+
		"2. For every correct answer you get one point\n"+
		"3. Enter exit to quit");
		HashSet<string> uniqueword = new HashSet<string>();
		int count=0;
		string word=" ";
		Console.WriteLine("Count of word"+words.Length);
		do{
		Console.WriteLine("Start entering your words");
		word=Console.ReadLine();
		for(int i=0;i<words.Length;i++){
		if(word.Equals(words[i]) && (!uniqueword.Contains(words[i]))){
		Console.WriteLine("Correct word\n");
		count++;
		uniqueword.Add(words[i]);
		break;
		}
		else if(word.Equals(words[i]) && (uniqueword.Contains(words[i]))){
		Console.WriteLine("Words cant be repeated");
		break;
		}
		else if(i==words.Length-1 && (!word.Equals(words[i]))){
		Console.WriteLine("Incorrect word");
		break;
		}
		}

		Console.WriteLine("Your score :{0}",count);

		}
		while(!word.Equals("exit"));

	}


}