using System;

public class Program
{
	public static void Main()
	{
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("Welcome to the Grand Epic Cool Style C# Maori Test!!! Created by Tobias Neumann. \n");
		Random rnd = new Random();
		int score = 0;

		// database of maori words and english meanings
		string[] array1 = { "iwi", "kai", "haere mai", "wahine", "e tu", "e noho", "whanua", "kia ora", "turituri", "morena" };
		string[] array2 = { "tribe", "food", "come here", "woman", "stand up", "sit down", "family", "hello", "shut up", "good morning" };

		// actual quiz, asking questions
		foreach (string element in array1)
		{
			// change text color of question back to white
			Console.ForegroundColor = ConsoleColor.White;
			int index = rnd.Next(10);
			Console.Write("What is the definition of: ");
			Console.WriteLine(array1[index]);
			string answer = Console.ReadLine();
			// a gap to look good
			Console.WriteLine("");

			//checks if answer is correct
			if (answer.ToLower() == array2[index])
            {
				// change text color
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Correct! \n");
				score++;
            }
            else
            {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Incorrect! \n");
            }
		}
	}
}