﻿using System;
using System.Linq;

string[] availableSigns = { "rock", "paper", "scissors" };
int firstPlayerPoints = 0;
int secondPlayerPoints = 0;
bool playingSolo = false;

Console.WriteLine("What's your name, player 1?");
string firstPlayerName = Console.ReadLine();
Console.WriteLine("What's your name, player 2?");
string secondPlayerName = Console.ReadLine();

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
	string firstSign = GetSign(firstPlayerName);
	if (firstSign == "quit")
	{
		break;
	}

	string secondSign;

	if (playingSolo)
	{
		int signIndex = rng.Next(availableSigns.Length);
		secondSign = availableSigns[signIndex];
		Console.WriteLine($"Computer chose {secondSign}");

		// secondSign = availableSigns[rng.Next(availableSigns.Length)];
	}
	else
	{
		secondSign = GetSign(secondPlayerName);

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
		Console.WriteLine($"{firstPlayerName} won");
	}
	else
	{
		secondPlayerPoints += 1;
		Console.WriteLine($"{secondPlayerName} won");
	}

	Console.WriteLine($"[{firstPlayerName}] {firstPlayerPoints} : {secondPlayerPoints} [{secondPlayerName}]");
}

Console.WriteLine("kthxbye");
Console.WriteLine("Press any key to close");
Console.ReadKey();

string GetSign(string playerName)
{
	Console.WriteLine($"Provide sign {playerName}");
	string sign = Console.ReadLine()?.ToLower().Trim();

	while (!availableSigns.Contains(sign) && sign != "quit")
	{
		Console.WriteLine("wrong sign");
		sign = Console.ReadLine()?.ToLower().Trim();
	}
	return sign;
}