/*
This program is a Maori test in 2 stages: Level 1, where the user writes a Maori word corresponding to a provided English word,
and Level 2, where the user picks one of three English words corresponding to a provided Maori word.
List of Maori words: maoriWords array (10 values)
List of English words: english array (10 values)

Level 1 -
foreach word in maoriWords
	Output("Input english[index1]")
	Input answer
	if answer lowercase is equal to the corresponding Maori word,
		Output("Correct!")
		increase score by 1
	else
		Output("Incorrect!")
	increase index by 1

Level 2 -
List of Maori words only for Level 2: maoriWords2 array (10 values)
List of English words only for Level 2: english2 array (10 values)
Run(index, random num1, random num2, answer position) ten times
inside Run() method -
	Output("Input place of meaning of maoriWords2[index]")
	if place of real answer is 1
		Output("1 - answer")
		Output("2 - random english word")
		Output("3 - another random english word')
	same for if real answer is 2 and 3
	user inputs answer
	while the inputted answer isnt an integer OR the inputted answer is invalid (< 0 or > 3)
		Output("Invalid input. Try again!")
		user inputs answer
	if the inputted answer is equal to the real answer
		Output("Correct!")
		score2 increases by 1 (score only for level 2)
		score increases by 1 (total score)
	index increases by 1
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
		Console.WriteLine("\nIncorrect! The correct answer was " + maoriWords[index1] + ".\n");
	}
	index1++;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Congratulations! You finished level 1! your score was " + score + "/10. \n \n");

// LEVEL 2: multichoice

// array for Level 2 words
string[] maoriWords2 = {"kaumatua", "kauri", "koha", "aroha", "awa", "haka", "hui", "karakia", "mahi", "mana" };
string[] english2 = {"elder", "large native tree", "gift", "love", "river", "maori dance", "gathering/meeting", "prayer", "work", "prestige/reputation" };

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
Run(3, 0, 9, 2);
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
	Console.WriteLine(maoriWords2[index]); // fetches the maori word from the array, corresponding to the current index
	Console.WriteLine("");

	if (realAnswer == 1)
    {
		Console.WriteLine("1 - " + english2[index]);
		Console.WriteLine("2 - " + english2[x]);
		Console.WriteLine("3 - " + english2[y]);
	}
	if (realAnswer == 2)
    {
		Console.WriteLine("1 - " + english2[x]);
		Console.WriteLine("2 - " + english2[index]);
		Console.WriteLine("3 - " + english2[y]);
	}
	if (realAnswer == 3)
    {
		Console.WriteLine("1 - " + english2[y]);
		Console.WriteLine("2 - " + english2[x]);
		Console.WriteLine("3 - " + english2[index]);
	}


	while (!int.TryParse(Console.ReadLine(), out answer2) || answer2 < 1 || answer2 > 3) // checks if answer is valid - if answer isnt an integer, user must input another answer
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write("\nPlease enter a valid number: ");
	}

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
		Console.WriteLine("\nIncorrect. The correct answer was " + realAnswer +  ".\n");
	}
	index++;
}

