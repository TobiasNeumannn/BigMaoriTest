	Random rnd = new Random(); // random number

	Console.ForegroundColor = ConsoleColor.Blue;
	Console.WriteLine("Welcome to the Grand C# Maori Test!!! Created by Tobias Neumann. \n");
	Console.WriteLine("Level 1");
	Console.WriteLine("-------");
	int score = 0; // num of questions answered correctly
	int index = 0; // place of maori/english word in the array

// array of maori words and english meanings. every maori word has the same index/place of its english meaning
string[] maoriWords = { "iwi", "kai", "haere mai", "wahine", "e tu", "e noho", "whanau", "kia ora", "turituri", "morena" };
	string[] english = { "tribe", "food", "come here", "woman", "stand up", "sit down", "family", "hello", "shut up", "good morning" };

// actual quiz (level 1), user types answers
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
	if ((answer.ToLower()) == maoriWords[index]) // answer.ToLower() coverts the answer to lowercase iso if user inputs capitals in their answer ("mAoRiWoRd") program still reads it as correct
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

Console.Write("Congratulations! You finished level 1! your score was " + score + "/10. \n \n");

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("Level 2: Input the number corresponding to the correct answer");
Console.WriteLine("-------");

Console.ForegroundColor = ConsoleColor.White;

// LEVEL 2: multichoice

index = 0;
int score2 = 0; // score for just level 2

	Console.ForegroundColor = ConsoleColor.White;
	Console.Write("What is the meaning of: ");
	Console.WriteLine(maoriWords[index]); // fetches the maori word from the array, corresponding to the current index
	Console.WriteLine("");

		Console.WriteLine("1 - " + english[index]);
		Console.WriteLine("2 - " + english[9]);
		Console.WriteLine("3 - " + english[8]);

	int realAnswer = 1;
	int userAnswer = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine(""); // gap to look good

	if ((userAnswer > 0) && (userAnswer < 4)) // checks if inputted number is valid
    {
		if (userAnswer == realAnswer) // checks if inputted answer is correct
        {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Correct! \n");
			score2++;
			score++;
        }
        else
        {
			Console.ForegroundColor = ConsoleColor.Red;

			Console.WriteLine("Incorrect. \n");
        }
    }
    else
    {
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Invalid Input. \n");
    }
	index++;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("What is the meaning of: ");
Console.WriteLine(maoriWords[index]); // fetches the maori word from the array, corresponding to the current index
Console.WriteLine("");

Console.WriteLine("1 - " + english[7]);
Console.WriteLine("2 - " + english[6]);
Console.WriteLine("3 - " + english[index]);

realAnswer = 1;
userAnswer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); // gap to look good

if ((userAnswer > 0) && (userAnswer < 4)) // checks if inputted number is valid
{
	if (userAnswer == realAnswer) // checks if inputted answer is correct
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Correct! \n");
		score2++;
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;

		Console.WriteLine("Incorrect. \n");
	}
}
else
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Invalid Input. \n");
}
index++;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("What is the meaning of: ");
Console.WriteLine(maoriWords[index]); // fetches the maori word from the array, corresponding to the current index
Console.WriteLine("");

Console.WriteLine("1 - " + english[4]);
Console.WriteLine("2 - " + english[5]);
Console.WriteLine("3 - " + english[index]);

realAnswer = 1;
userAnswer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); // gap to look good

if ((userAnswer > 0) && (userAnswer < 4)) // checks if inputted number is valid
{
	if (userAnswer == realAnswer) // checks if inputted answer is correct
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Correct! \n");
		score2++;
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;

		Console.WriteLine("Incorrect. \n");
	}
}
else
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Invalid Input. \n");
}
index++;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("What is the meaning of: ");
Console.WriteLine(maoriWords[index]); // fetches the maori word from the array, corresponding to the current index
Console.WriteLine("");

Console.WriteLine("1 - " + english[3]);
Console.WriteLine("2 - " + english[index]);
Console.WriteLine("3 - " + english[2]);

realAnswer = 1;
userAnswer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); // gap to look good

if ((userAnswer > 0) && (userAnswer < 4)) // checks if inputted number is valid
{
	if (userAnswer == realAnswer) // checks if inputted answer is correct
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Correct! \n");
		score2++;
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;

		Console.WriteLine("Incorrect. \n");
	}
}
else
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Invalid Input. \n");
}
index++;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("What is the meaning of: ");
Console.WriteLine(maoriWords[index]); // fetches the maori word from the array, corresponding to the current index
Console.WriteLine("");

Console.WriteLine("1 - " + english[4]);
Console.WriteLine("2 - " + english[1]);
Console.WriteLine("3 - " + english[index]);

realAnswer = 1;
userAnswer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); // gap to look good

if ((userAnswer > 0) && (userAnswer < 4)) // checks if inputted number is valid
{
	if (userAnswer == realAnswer) // checks if inputted answer is correct
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Correct! \n");
		score2++;
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;

		Console.WriteLine("Incorrect. \n");
	}
}
else
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Invalid Input. \n");
}
index++;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("What is the meaning of: ");
Console.WriteLine(maoriWords[index]); // fetches the maori word from the array, corresponding to the current index
Console.WriteLine("");

Console.WriteLine("1 - " + english[index]);
Console.WriteLine("2 - " + english[6]);
Console.WriteLine("3 - " + english[3]);

realAnswer = 1;
userAnswer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); // gap to look good

if ((userAnswer > 0) && (userAnswer < 4)) // checks if inputted number is valid
{
	if (userAnswer == realAnswer) // checks if inputted answer is correct
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Correct! \n");
		score2++;
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;

		Console.WriteLine("Incorrect. \n");
	}
}
else
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Invalid Input. \n");
}
index++;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("What is the meaning of: ");
Console.WriteLine(maoriWords[index]); // fetches the maori word from the array, corresponding to the current index
Console.WriteLine("");

Console.WriteLine("1 - " + english[5]);
Console.WriteLine("2 - " + english[7]);
Console.WriteLine("3 - " + english[index]);

realAnswer = 1;
userAnswer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); // gap to look good

if ((userAnswer > 0) && (userAnswer < 4)) // checks if inputted number is valid
{
	if (userAnswer == realAnswer) // checks if inputted answer is correct
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Correct! \n");
		score2++;
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;

		Console.WriteLine("Incorrect. \n");
	}
}
else
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Invalid Input. \n");
}
index++;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("What is the meaning of: ");
Console.WriteLine(maoriWords[index]); // fetches the maori word from the array, corresponding to the current index
Console.WriteLine("");

Console.WriteLine("1 - " + english[index]);
Console.WriteLine("2 - " + english[4]);
Console.WriteLine("3 - " + english[8]);

realAnswer = 1;
userAnswer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); // gap to look good

if ((userAnswer > 0) && (userAnswer < 4)) // checks if inputted number is valid
{
	if (userAnswer == realAnswer) // checks if inputted answer is correct
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Correct! \n");
		score2++;
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;

		Console.WriteLine("Incorrect. \n");
	}
}
else
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Invalid Input. \n");
}
index++;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("What is the meaning of: ");
Console.WriteLine(maoriWords[index]); // fetches the maori word from the array, corresponding to the current index
Console.WriteLine("");

Console.WriteLine("1 - " + english[2]);
Console.WriteLine("2 - " + english[index]);
Console.WriteLine("3 - " + english[7]);

realAnswer = 1;
userAnswer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); // gap to look good

if ((userAnswer > 0) && (userAnswer < 4)) // checks if inputted number is valid
{
	if (userAnswer == realAnswer) // checks if inputted answer is correct
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Correct! \n");
		score2++;
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;

		Console.WriteLine("Incorrect. \n");
	}
}
else
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Invalid Input. \n");
}
index++;

Console.ForegroundColor = ConsoleColor.White;
Console.Write("What is the meaning of: ");
Console.WriteLine(maoriWords[index]); // fetches the maori word from the array, corresponding to the current index
Console.WriteLine("");

Console.WriteLine("1 - " + english[index]);
Console.WriteLine("2 - " + english[10]);
Console.WriteLine("3 - " + english[5]);

realAnswer = 1;
userAnswer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); // gap to look good

if ((userAnswer > 0) && (userAnswer < 4)) // checks if inputted number is valid
{
	if (userAnswer == realAnswer) // checks if inputted answer is correct
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Correct! \n");
		score2++;
		score++;
	}
	else
	{
		Console.ForegroundColor = ConsoleColor.Red;

		Console.WriteLine("Incorrect. \n");
	}
}
else
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine("Invalid Input. \n");
}
index++;

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Congratulations! You finished level 2! your score for level 2 was " + score2 + "/10 and your total score is " + score + "/20. \n");
Console.ForegroundColor = ConsoleColor.White;








