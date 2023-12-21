string[] availableSigns = {"rock", "paper", "scissors"};
int firstPlayerPoints = 0;
int secondPlayerPoints = 0;

Console.WriteLine("How many wins to win?");
// winsToWin = int.Parse(Console.ReadLine());
bool parsingResult = int.TryParse(Console.ReadLine(), out int winsToWin);
if (!parsingResult)
{
	winsToWin = 3;
}

Console.WriteLine(winsToWin);

// bool isPlaying = true;

//while (isPlaying)
// while(!(firstPlayerPoints >= 3 || secondPlayerPoints >= 3))
while(firstPlayerPoints < winsToWin && secondPlayerPoints < winsToWin)
{
	Console.WriteLine("Provide sign player 1");
	string? firstSign = Console.ReadLine()?.ToLower().Trim();

	while (!availableSigns.Contains(firstSign) && firstSign != "quit")
	{
		Console.WriteLine("wrong sign");
		firstSign = Console.ReadLine()?.ToLower().Trim();
	}

	if (firstSign == "quit")
	{
		break;
	}

	Console.WriteLine("Provide sign player 2");
	string? secondSign = Console.ReadLine()?.ToLower().Trim();

	while (!availableSigns.Contains(secondSign) && secondSign != "quit")
	{
		Console.WriteLine("wrong sign");
		secondSign = Console.ReadLine()?.ToLower().Trim();
	}

	if (secondSign == "quit")
	{
		break;
	}

	int secondSignIndex = Array.IndexOf(availableSigns, secondSign);
	int spswi = (secondSignIndex + 1) % availableSigns.Length;
	string secondSignWinningSign = availableSigns[spswi];
	
	if (firstSign == secondSign)
	{
		Console.WriteLine("It's a draw");
	}
	else if (firstSign == secondSignWinningSign)
	{
		firstPlayerPoints += 1;
		Console.WriteLine("player 1 won");
	}
	else
	{
		secondPlayerPoints += 1;
		Console.WriteLine("player 2 won");
	}

	//Console.WriteLine("[Player 1] " + firstPlayerPoints + " : " + secondPlayerPoints + " [Player 2]");
	Console.WriteLine($"[Player 1] {firstPlayerPoints} : {secondPlayerPoints} [Player 2]");

	// if (firstPlayerPoints >= 3 || secondPlayerPoints >= 3)
	// {
	// 	// break;
	// 	isPlaying = false;
	// }
}

Console.WriteLine("kthxbye");
Console.WriteLine("Press any key to close");
Console.ReadKey();