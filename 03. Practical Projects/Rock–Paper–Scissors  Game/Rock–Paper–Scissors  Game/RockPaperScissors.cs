// See https://aka.ms/new-console-template for more information
const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove=Console.ReadLine();
if (playerMove== "r" || playerMove=="rock")
{
    playerMove = Rock;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = Paper;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid input. Try again...");
    return;
}
Random random = new Random();
int computerRandomNumber=random.Next(1, 4);
string computerMove = "";
switch (computerRandomNumber)
{
    case 1:
        computerMove = Rock;

    break;
        case 2:
        computerMove = Paper;
        break;

        case 3:
        computerMove = Scissors;
                break;
}
Console.ForegroundColor = ConsoleColor.Red;

Console.WriteLine($"The computer chose {computerMove}.");
Console.ResetColor();
if ((playerMove==Rock&&computerMove==Scissors)||(playerMove==Paper&&computerMove==Rock)||(playerMove==Scissors&&computerMove==Paper))
{
    Console.ForegroundColor = ConsoleColor.Green;
   
    Console.WriteLine("You win.");
    Console.ResetColor();
}
else if ((playerMove == Scissors && computerMove == Rock) || (playerMove == Rock && computerMove == Paper) || (playerMove == Paper && computerMove == Scissors))
{
    Console.ForegroundColor = ConsoleColor.Green;
   
    Console.WriteLine("You loose.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("This game was a draw.");
    Console.ResetColor();
}
