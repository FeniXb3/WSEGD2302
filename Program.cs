string[] availableSigns = { "rock", "paper", "scissors" };
int firstPlayerPoints = 0;
int secondPlayerPoints = 0;
bool playingSolo = true;

Random rng = new Random();

// for (int i = 0; i < 10; i++)
// {
// 	int randomNumber = rng.Next(3);
// 	Console.WriteLine(randomNumber);
// }

Console.WriteLine("How many wins to win?");
bool parsingResult = int.TryParse(Console.ReadLine(), out int winsToWin);
if (!parsingResult)
{
	winsToWin = 3;
}

Console.WriteLine(winsToWin);

while (firstPlayerPoints < winsToWin && secondPlayerPoints < winsToWin)
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

	string? secondSign;

	if (playingSolo)
	{
		int signIndex = rng.Next(availableSigns.Length);
		secondSign = availableSigns[signIndex];
		Console.WriteLine($"Computer chose {secondSign}");

		// secondSign = availableSigns[rng.Next(availableSigns.Length)];
	}
	else
	{
		Console.WriteLine("Provide sign player 2");
		secondSign = Console.ReadLine()?.ToLower().Trim();

		while (!availableSigns.Contains(secondSign) && secondSign != "quit")
		{
			Console.WriteLine("wrong sign");
			secondSign = Console.ReadLine()?.ToLower().Trim();
		}

		if (secondSign == "quit")
		{
			break;
		}
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

	Console.WriteLine($"[Player 1] {firstPlayerPoints} : {secondPlayerPoints} [Player 2]");
}

Console.WriteLine("kthxbye");
Console.WriteLine("Press any key to close");
Console.ReadKey();