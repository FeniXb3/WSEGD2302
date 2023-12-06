string[] availableSigns = {"rock", "paper", "scissors"};
int firstPlayerPoints = 0;
int secondPlayerPoints = 0;

while(true)
{
	Console.WriteLine("Provide sign player 1");
	string? firstSign = Console.ReadLine().ToLower().Trim();

	while (!availableSigns.Contains(firstSign) && firstSign != "quit")
	{
		Console.WriteLine("wrong sign");
		firstSign = Console.ReadLine().ToLower().Trim();
	}

	if (firstSign == "quit")
	{
		break;
	}

	Console.WriteLine("Provide sign player 2");
	string? secondSign = Console.ReadLine().ToLower().Trim();

	while (!availableSigns.Contains(secondSign) && secondSign != "quit")
	{
		Console.WriteLine("wrong sign");
		secondSign = Console.ReadLine().ToLower().Trim();
	}

	if (secondSign == "quit")
	{
		break;
	}

	int secondSignIndex = Array.IndexOf(availableSigns, secondSign);
	int spswi = (secondSignIndex + 1) % availableSigns.Length;
	string secondSignWinningSign = availableSigns[spswi];
	//string secondSignWinningSign = availableSigns[(Array.IndexOf(availableSigns, secondSign) + 1) % availableSigns.Length];

	if (firstSign == secondSign)
	{
		Console.WriteLine("It's a draw");
	}
	// else if ((firstSign == "rock" && secondSign == "scissors") ||
	// 	(firstSign == "paper" && secondSign == "rock") ||
	// 	(firstSign == "scissors" && secondSign == "paper"))
	else if (firstSign == secondSignWinningSign)
	{
		// firstPlayerPoints = firstPlayerPoints + 1;
		firstPlayerPoints += 1;
		// firstPlayerPoints++;
		Console.WriteLine("player 1 won");
	}
	else
	{
		secondPlayerPoints += 1;
		Console.WriteLine("player 2 won");
	}
}

Console.WriteLine("kthxbye");