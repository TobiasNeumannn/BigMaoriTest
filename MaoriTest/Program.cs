
	Console.ForegroundColor = ConsoleColor.Blue;
	Console.WriteLine("Welcome to the Grand Epic Cool Style C# Maori Test!!! Created by Tobias Neumann. \n");
	Random rnd = new Random();
	int score = 0;
	int index;

	// database of maori words and english meanings
	string[] maoriWords = { "iwi", "kai", "haere mai", "wahine", "e tu", "e noho", "whanua", "kia ora", "turituri", "morena" };
	string[] english = { "tribe", "food", "come here", "woman", "stand up", "sit down", "family", "hello", "shut up", "good morning" };

// actual quiz, asking questions
foreach (string element in maoriWords)
{
	// change text color of question back to white
	Console.ForegroundColor = ConsoleColor.White;
	index = rnd.Next(10);
	Console.Write("What is the definition of: ");
	Console.WriteLine(maoriWords[index]);
	string answer = Console.ReadLine();
	// a gap to look good
	Console.WriteLine("");

	//checks if answer is correct
	if ((answer.ToLower()) == english[index])
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

Console.Write("Congratulations! You finished the quiz! your score was: ");
Console.WriteLine(score);





