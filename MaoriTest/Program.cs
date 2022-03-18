﻿
	Console.ForegroundColor = ConsoleColor.Blue;
	Console.WriteLine("Welcome to the Grand C# Maori Test!!! Created by Tobias Neumann. \n");
	Random rnd = new Random();
	int score = 0;
	int index = 0;

	// database of maori words and english meanings
	string[] maoriWords = { "iwi", "kai", "haere mai", "wahine", "e tu", "e noho", "whanau", "kia ora", "turituri", "morena" };
	string[] english = { "tribe", "food", "come here", "woman", "stand up", "sit down", "family", "hello", "shut up", "good morning" };
	int[] oldIndex = { };
	
// actual quiz, asking questions
foreach (string word in maoriWords)
{
	// change text color of question back to white
	Console.ForegroundColor = ConsoleColor.White;
	index = Unique();
	Console.Write("What is the maori word for: ");
	Console.WriteLine(english[index]);
	string answer = Console.ReadLine();
	// a gap to look good
	Console.WriteLine("");

	

	//checks if answer is correct
	if ((answer.ToLower()) == maoriWords[index])
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

Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Congratulations! You finished the quiz! your score was: ");
Console.WriteLine(score);

Console.ForegroundColor = ConsoleColor.White;

// ensures that questions do not repeat
int Unique()
{
	int[] usedNumbers = new int[10]; // array of used words
	bool unique = false;
	int rndNumber = rnd.Next(10);

	while (!unique)
	{
		if (!usedNumbers.Contains(rndNumber))
		{
			usedNumbers[index] = rndNumber;
			unique = true;
			index++;
		}
		else
		{
			rndNumber = rnd.Next(10);
		}
	}

	return rndNumber;
}





