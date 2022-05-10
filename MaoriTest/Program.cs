/*
This program is a Maori test with 3 different levels/difficulties: Level 1, where the user writes a Maori word corresponding to a provided English word, 
Level 2, where the user picks one of three English words corresponding to a provided Maori word,
and Level 3, where the user picks of of three Maori words to fit inside an English sentence.

List of Maori words: maoriWords array (10 values)
List of English words: english array (10 values)

List of Maori words only for Level 2: maoriWords2 array (10 values)
List of English words only for Level 2: english2 array (10 values)

The levels exist inside a while loop that keeps running until the user chooses to exit the program. At the beginning of the loop, the user may pick a level to play or quit.
The levels exist in an if statement which will begin a certain level based on what number the user enters (1 for Level 1, etc.). The program will close if the user enters any number other than 1, 2, or 3.

Level 1 -
foreach word in maoriWords
	Output("Input english[index1]")
	user inputs answer
	if answer converted to lowercase is equal to the corresponding Maori word,
		Output("Correct!")
		increase score by 1
	else
		Output("Incorrect! The correct answer was [correct answer].")
	increase index by 1

Level 2 -
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
		score increases by 1 (total score)
	else
		Output("Incorrect. The correct answer was [correct answer]")
	index increases by 1

Level 3 - 
Sentence(index, random num1, random num2, answer position, unfinished sentence) ten times
inside Sentence() method -
	Output("Finish the sentence: ")
	Output sentence
	if place of real answer is 1
		Output("1 - answer")
		Output("2 - random maori word")
		Output("3 - another random maori word')
	same for if real answer is 2 and 3
	user inputs answer
	while the inputted answer isnt an integer OR the inputted answer is invalid (< 0 or > 3)
		Output("Invalid input. Try again!")
		user inputs answer
	if the inputted answer is equal to the real answer
		Output("Correct!")
		score increases by 1 (total score)
	else
		Output("Incorrect. The correct answer was [correct answer]")
	index increases by 1
*/

// array of maori words and english meanings. every maori word has the same index/place of its english meaning
string[] maoriWords = { "iwi", "kai", "haere mai", "wahine", "e tu", "e noho", "whanau", "kia ora", "turituri", "morena" };
string[] english = { "tribe", "food", "come here", "woman", "stand up", "sit down", "family", "hello", "shut up", "good morning" };

// array for Level 2 words
string[] maoriWords2 = { "kaumatua", "kauri", "koha", "aroha", "awa", "haka", "hui", "karakia", "mahi", "mana" };
string[] english2 = { "elder", "large native tree", "gift", "love", "river", "maori dance", "gathering/meeting", "prayer", "work", "prestige/reputation" };

int answer2;

int score = 0; // num of questions answered correctly in total quiz
int index1 = 0; // place of maori/english word in the array

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Welcome to the Grand C# Maori Test!!! Created by Tobias Neumann. \n");

while (true)
{
	Console.WriteLine("Would you like to do Level 1 (easy), Level 2 (normal), Level 3 (hard), or quit?");
	Console.WriteLine("(Please enter 1, 2, 3, or any other number to quit.) \n ");

	int level;
	while (!int.TryParse(Console.ReadLine(), out level)) // checks if answer is valid - if answer isnt an integer, user must input another answer
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write("\nPlease enter a valid answer: ");
	}
	Console.ForegroundColor = ConsoleColor.White;
	Console.WriteLine("");

	if (level == 1)
	{
		Console.WriteLine("Level 1");
		Console.WriteLine("-------");

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
		Console.WriteLine("Congratulations! You finished level 1! your score was " + score + "/10. \n \n");

		score = 0; // resets score
		index1 = 0; // resets index
	}
	else if (level == 2)
	{
		// LEVEL 2: multichoice

		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Level 2: Input the number corresponding to the correct answer");
		Console.WriteLine("-------");
		Console.ForegroundColor = ConsoleColor.White;

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
		Console.WriteLine("Congratulations! You finished level 2! your score for level 2 was " + score + "/10. \n");
		Console.ForegroundColor = ConsoleColor.White;

		score = 0;
	}
	else if (level == 3)
    {
		// LEVEL 3: finish the sentence

		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Level 3: Finish the sentence by inputting the number corresponding to the correct answer");
		Console.WriteLine("-------");
		Console.ForegroundColor = ConsoleColor.White;

		// 10 questions
		Sentence(0, 9, 8, 1, "A large proportion of the Māori population are from the Ngāi Tahu ___.");
		Sentence(1, 7, 6, 3, "I could really go for some ___ right now!");
		Sentence(2, 0, 6, 3, "'___' She said as they approached the marae.");
		Sentence(3, 1, 9, 2, "He held a conversation with the tall ___.");
		Sentence(4, 8, 5, 3, "'___!' He commanded, and they stood.");
		Sentence(5, 7, 2, 1, "They said '___' to the standing crowd.");
		Sentence(6, 4, 1, 2, "I'm exited to spend these holidays with my ___.");
		Sentence(7, 8, 9, 2, "'___!' She said, greeting him.");
		Sentence(8, 5, 3, 1, "The teacher told the noisy class to ___.");
		Sentence(9, 7, 5, 3, "'___! The sun is so bright today!.'");

		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Congratulations! You finished level 3! your score for level 2 was " + score + "/10. \n");
		Console.ForegroundColor = ConsoleColor.White;

		score = 0;
		index1 = 0;
	}
	else
	{
		Environment.Exit(0);
	}
}

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
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("\nIncorrect. The correct answer was " + realAnswer +  ".\n");
	}
	index++;
}

void Sentence(int index, int x, int y, int realAnswer, string sentence)
{
	Console.ForegroundColor = ConsoleColor.White;
	Console.Write(index + 1 + " - Finish the sentence: ");
	Console.WriteLine(sentence);
	Console.WriteLine("");

	if (realAnswer == 1)
	{
		Console.WriteLine("1 - " + maoriWords[index]);
		Console.WriteLine("2 - " + maoriWords[x]);
		Console.WriteLine("3 - " + maoriWords[y]);
	}
	if (realAnswer == 2)
	{
		Console.WriteLine("1 - " + maoriWords[x]);
		Console.WriteLine("2 - " + maoriWords[index]);
		Console.WriteLine("3 - " + maoriWords[y]);
	}
	if (realAnswer == 3)
	{
		Console.WriteLine("1 - " + maoriWords[y]);
		Console.WriteLine("2 - " + maoriWords[x]);
		Console.WriteLine("3 - " + maoriWords[index]);
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
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("\nIncorrect. The correct answer was " + realAnswer + ".\n");
	}
	index++;
}

