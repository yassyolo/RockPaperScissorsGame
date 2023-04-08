const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.Write("Choose rock[r], paper[p], scissors[s]: ");
string playerMove = Console.ReadLine();
if (playerMove == "r")
{
    playerMove = Rock;
}
else if (playerMove == "p")
{
    playerMove = Paper;
}
else if (playerMove == "s")
{
    playerMove = Scissors;
}
else
{
    Console.WriteLine("Invalid input. Try again...");
}
Random rnd = new Random();
int computerMoveNum = rnd.Next(1, 4);
string computerMove = string.Empty;

switch(computerMoveNum)
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
Console.WriteLine($"The computer chose: {computerMove}");

if (playerMove == Rock && computerMove == Scissors || playerMove == Paper && computerMove == Rock || playerMove == Scissors && computerMove == Paper)
{
    Console.WriteLine("You win!");
}
else if (playerMove == Rock && computerMove == Rock || playerMove == Paper && computerMove == Paper|| playerMove == Scissors && computerMove == Scissors)
{
    Console.WriteLine("Draw!");
}
else
{
    Console.WriteLine("You lose!");
}

