
	Console.ForegroundColor = ConsoleColor.Blue;
	Console.WriteLine("Welcome to the Grand C# Maori Test!!! Created by Tobias Neumann. \n");
	int score = 0; // num of questions answered correctly
	int index = 0; // place of maori/english word in the array

// array of maori words and english meanings. every maori word has the same index/place of its english meaning
string[] maoriWords = { "iwi", "kai", "haere mai", "wahine", "e tu", "e noho", "whanau", "kia ora", "turituri", "morena" };
	string[] english = { "tribe", "food", "come here", "woman", "stand up", "sit down", "family", "hello", "shut up", "good morning" };
	int[] oldNumbers = new int[10]; // array of used indexes

// actual quiz, asking questions
foreach (string word in maoriWords)
{
	// change text color of question to white
	Console.ForegroundColor = ConsoleColor.White;
	Console.Write("What is the maori word for: ");
	Console.WriteLine(english[index]); // fetches the english word from the array, corresponding to the current index
	string answer = Console.ReadLine();
	// a gap to look good
	Console.WriteLine("");

	//checks if answer is correct
	if ((answer.ToLower()) == maoriWords[index]) // answer.ToLower() coverts the answer to lowercase so if user inputs capitals in their answer ("mAoRiWoRd") program still reads it as correct
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
	index++;
}

Console.ForegroundColor = ConsoleColor.Green;

Console.Write("Congratulations! You finished the quiz! your score was: ");
Console.WriteLine(score);

Console.ForegroundColor = ConsoleColor.White;






