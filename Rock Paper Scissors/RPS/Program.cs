const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.Write("Choose [r]ock, [p]aper, or [s]cissors: ");

chooseAgain:
playAgain:

string playerMove = Console.ReadLine();

if (playerMove == "r" || playerMove == "R" || 
    playerMove =="rock" || playerMove == "Rock")
{
    playerMove = Rock;
}

else if(playerMove == "p" || playerMove == "P" || 
    playerMove == "paper" || playerMove == "Paper")
{
    playerMove = Paper;
}

else if (playerMove == "s" || playerMove == "S" || 
    playerMove == "scissors" || playerMove == "Scissors")
{
    playerMove = Scissors;
}

else
{
    Console.Write("Invalid Input.. Are you stupid? Pleasae try again:  ");
    goto chooseAgain;
}


Random random = new Random();
int pcRandomMove = random.Next(1, 4);
string computerMove = String.Empty;

switch (pcRandomMove)
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

Console.WriteLine($"Ivo's beast PC chose {computerMove}");
Console.WriteLine();

if(
    (playerMove == Rock && computerMove == Paper) 
    || (playerMove == Paper && computerMove == Scissors)
    || (playerMove == Scissors && computerMove == Rock)
  )
{
    Console.WriteLine("LMFAO you lose!");
}

else if (
    (playerMove == Rock && computerMove == Scissors)
    || (playerMove == Paper && computerMove == Rock)
    || (playerMove == Scissors && computerMove == Paper)
  )
{
    Console.WriteLine("GG you win!");
}

else
{
    Console.WriteLine("This game was draw");
}
Console.WriteLine();
Console.Write("Do you want to play another game? [Y] , [N]: ");

string answer = Console.ReadLine();

if (answer == "y" || answer == "Y")
{
    Console.Write("Choose [r]ock, [p]aper, or [s]cissors: ");
    goto playAgain;
}
else
{
    Console.WriteLine("Thanks for playing!");
    return;
}
