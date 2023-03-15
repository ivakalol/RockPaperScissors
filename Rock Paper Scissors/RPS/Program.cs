bool playAgain = true;
bool validAnswer = true;

Console.WriteLine("Let's play Rock Paper Scissors...");
Console.Write("Please select your move ([R]ock / [P]aper / [S]cissors): ");

while (playAgain)
{
	string answer = Console.ReadLine().ToUpper();
	CheckValidAnswer(ref answer, ref validAnswer);

	string playerMove = string.Empty;
    string computerMove = string.Empty;
	
    ValidateMove(ref playerMove, answer);
	ChoseComputerMove(ref computerMove);
	CheckWinner(computerMove, playerMove);

	Console.WriteLine();
	Console.Write("Do you want to play another one [Y]es / [Any Other Key]: ");
	answer = Console.ReadLine().ToUpper();

	if (answer == "Y")
	{
		Console.Write("Super, now choose again from [R]ock / [P]aper / [S]cissors: ");
		Console.WriteLine();
		playAgain = true;
	}
	else
	{
		playAgain = false;
	}
}


Console.WriteLine("---------------------");
Console.WriteLine("It was a pleasure playing with you");
Console.WriteLine("<3");


void CheckValidAnswer(ref string answer, ref bool validAnswer)
{
	validAnswer = false;
	while (!validAnswer)
	{
		if (answer == "R" || answer == "P" || answer == "S") { validAnswer = true; }
		else
		{
			Console.Write("Please select a valid option ([R]/[P]/[S]): ");
			answer = Console.ReadLine().ToUpper();
		}
	}
}

void ValidateMove(ref string move, string answer)
{
    if (answer == "R")
	{
		move = "ROCK";
	}
	else if (answer == "P")
	{
		move = "PAPER";
	}
	else
	{
		move = "SCISSORS";
	}
}

void ChoseComputerMove(ref string computerMove)
{
    Random randomMove = new Random();
	
	switch (randomMove.Next(1, 4))
	{
		case 1:
			computerMove = "PAPER"; break;
		case 2:
			computerMove = "ROCK"; break;
		case 3:
			computerMove = "SCISSORS"; break;
    }
}


void CheckWinner(string computerMove, string playerMove)
{
	Console.WriteLine();
	Console.WriteLine($"PLAYER: {playerMove}");
    Console.WriteLine($"COMPUTER: {computerMove}");
	Console.WriteLine();

    switch (playerMove)
	{
		case "ROCK":
			if (computerMove == "ROCK")
			{
				Console.WriteLine($"I also chose {playerMove.ToLower()}..");
				Console.WriteLine("Its a draw : /");
			}
			else if (computerMove == "PAPER")
            {
                Console.WriteLine("Loser! I have beaten you with paper xD");
            }
			else if (computerMove == "SCISSORS")
            {
                Console.WriteLine("Damn you are really good at this game..");
				Console.WriteLine("You win!");
            }
            break;

		case "SCISSORS":
            if (computerMove == "ROCK")
            {
                Console.WriteLine("Loser! I have beaten you with paper xD");
            }
            else if (computerMove == "PAPER")
            {
                Console.WriteLine("Damn you are really good at this game..");
                Console.WriteLine("You win!");
            }
            else if (computerMove == "SCISSORS")
            {
                Console.WriteLine($"I also chose {playerMove.ToLower()}..");
                Console.WriteLine("Its a draw : /");
            }
            break;

		case "PAPER":
            if (computerMove == "ROCK")
            {
                Console.WriteLine("Damn you are really good at this game..");
				Console.WriteLine("You win!");
            }
            else if (computerMove == "PAPER")
            {
                Console.WriteLine($"I also chose {playerMove.ToLower()}..");
                Console.WriteLine("Its a draw : /");
            }
            else if (computerMove == "SCISSORS")
            {
                Console.WriteLine("Loser! I have beaten you with paper xD");
            }
            break;
	}
}