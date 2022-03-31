/*
This program is a Maori Vocabulary Test in two stages.
The maoriWords array contains 10 Maori words.
The english array contains 10 English words, that correspond to the maori word in the same place in the other array.
Level 1 of the test in contained in a foreach loop that repeats for every word in the maoriWords array (10 times).
Inside the loop, the code will prompt the user to enter the Maori word for the first English word in the english array.
The word in the english array is represented by index1, an integer that starts as 0, and increases by one at the end of the loop.


*/

	Console.ForegroundColor = ConsoleColor.Blue;
	Console.WriteLine("Welcome to the Grand C# Maori Test!!! Created by Tobias Neumann. \n");
	Console.WriteLine("Level 1");
	Console.WriteLine("-------");

	int score = 0; // num of questions answered correctly
	int index1 = 0; // place of maori/english word in the array

// array of maori words and english meanings. every maori word has the same index/place of its english meaning
string[] maoriWords = { "iwi", "kai", "haere mai", "wahine", "e tu", "e noho", "whanau", "kia ora", "turituri", "morena" };
	string[] english = { "tribe", "food", "come here", "woman", "stand up", "sit down", "family", "hello", "shut up", "good morning" };

// actual quiz (level 1), user types answers
foreach (string word in maoriWords)
{
	// change text color of question to white
	Console.ForegroundColor = ConsoleColor.White;
	Console.Write(index1 + 1 + " - What is the maori word for: ");
	Console.WriteLine(english[index1]); // fetches the english word from the array, corresponding to the current index
	string answer = Console.ReadLine();

	//checks if answer is correct
	if ((answer.ToLower()) == maoriWords[index1]) // answer.ToLower() coverts the answer to lowercase so if user inputs capitals in their answer ("mAoRiWoRd") program still reads it as correct
	{
		// change text color
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("\nCorrect! \n");
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("\nIncorrect! \n");
	}
	index1++;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Congratulations! You finished level 1! your score was " + score + "/10. \n \n");

// LEVEL 2: multichoice

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Level 2: Input the number corresponding to the correct answer");
Console.WriteLine("-------");
Console.ForegroundColor = ConsoleColor.White;

int answer2;
int score2 = 0; // score for just level 2

// 10 questions
Run(0, 9, 8, 1);
Run(1, 7, 6, 3);
Run(2, 4, 5, 3);
Run(3, 0, 2, 2);
Run(4, 8, 5, 3);
Run(5, 7, 0, 1);
Run(6, 4, 1, 2);
Run(7, 8, 9, 2);
Run(8, 5, 3, 1);
Run(9, 7, 5, 3);

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Congratulations! You finished level 2! your score for level 2 was " + score2 + "/10 and your total score is " + score + "/20. \n");
Console.ForegroundColor = ConsoleColor.White;

void Run(int index, int x, int y, int realAnswer) // one question - index is the place of the word in the array, x and y are numbers chosen randomly, and realAnswer is the place of the real answer
{

	Console.ForegroundColor = ConsoleColor.White;
	Console.Write(index + 1 + " - What is the meaning of: ");
	Console.WriteLine(maoriWords[index]); // fetches the maori word from the array, corresponding to the current index
	Console.WriteLine("");

	if (realAnswer == 1)
    {
		Console.WriteLine("1 - " + english[index]);
		Console.WriteLine("2 - " + english[x]);
		Console.WriteLine("3 - " + english[y]);
	}
	if (realAnswer == 2)
    {
		Console.WriteLine("1 - " + english[x]);
		Console.WriteLine("2 - " + english[index]);
		Console.WriteLine("3 - " + english[y]);
	}
	if (realAnswer == 3)
    {
		Console.WriteLine("1 - " + english[y]);
		Console.WriteLine("2 - " + english[x]);
		Console.WriteLine("3 - " + english[index]);
	}


	while (!int.TryParse(Console.ReadLine(), out answer2)) // checks if answer is valid - if answer isnt an integer, user must input another answer
	{
		Console.Write("\nPlease enter a valid number: ");
	}

	if ((answer2 > 0) && (answer2 < 4)) // checks if inputted number is valid
	{
		if (answer2 == realAnswer) // checks if inputted answer is correct
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nCorrect! \n");
			score2++;
			score++;
		}
		else
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\nIncorrect. \n");
		}
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("\nInvalid Input. \n");
	}
	index++;
}