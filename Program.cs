// See https://aka.ms/new-console-template for more information
Console.WriteLine("Provide sign player 1");
string firstSign = Console.ReadLine();
Console.WriteLine(firstSign);

Console.WriteLine("Provide sign player 2");
string secondSign = Console.ReadLine();
Console.WriteLine(secondSign);

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
