using System;

while(true)
{
	Console.WriteLine("Provide sign player 1");
	string firstSign = Console.ReadLine();
	if (firstSign == "quit")
	{
		break;
	}

	//if (!(firstSign == "rock" || firstSign == "paper" || firstSign == "scissors"))
	//if ((firstSign == "rock" || firstSign == "paper" || firstSign == "scissors") == false)
	while (firstSign != "rock" && firstSign != "paper" && firstSign != "scissors")
	{
		Console.WriteLine("wrong sign");
		firstSign = Console.ReadLine();
		if (firstSign == "quit")
		{
			break;
		}
	}

	Console.WriteLine("Provide sign player 2");
	string secondSign = Console.ReadLine();

	while (secondSign != "rock" && secondSign != "paper" && secondSign != "scissors")
	{
		Console.WriteLine("wrong sign");
		secondSign = Console.ReadLine();
	}

	if (firstSign == secondSign)
	{
		Console.WriteLine("It's a draw");
	}
	else if ((firstSign == "rock" && secondSign == "scissors") ||
		(firstSign == "paper" && secondSign == "rock") ||
		(firstSign == "scissors" && secondSign == "paper"))
	{
		Console.WriteLine("player 1 won");
	}
	else
	{
		Console.WriteLine("player 2 won");
	}
	// 1. pobierz znaki od graczy
	// 2. sprawdz czy jest remis
	// 3. sprawdz czy wygrywa gracz 1
}

Console.WriteLine("kthxbye");