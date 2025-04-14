internal class Program
{
  static int PlayerWins = 0;
  static int ComputerWins = 0;
  private static void Main()
  {
    Console.Clear();
    Console.WriteLine("Howdily-doodily, neighborino!");
    Console.WriteLine($"Current Score: Player - {PlayerWins}, Computer - {ComputerWins}");

    string userHand = chooseHand();
    string computerHand = getComputerHand();
    Console.WriteLine($"You chose: {userHand}");
    Console.WriteLine($"Computer Chose: {computerHand}");
    string result = DetermineWinner(userHand, computerHand);
    Console.WriteLine(result);
    Console.WriteLine($"Player Wins: {PlayerWins}, Computer Wins: {ComputerWins}");

    PlayAgain();

    static string chooseHand()
    {
      Console.WriteLine("Choose A Hand");
      Console.WriteLine("1. Rock");
      Console.WriteLine("2. Paper");
      Console.WriteLine("3. Scissors");
      string userInput = Console.ReadLine();

      switch (userInput)
      {
        case "1":
          return "Rock";
        case "2":
          return "Paper";
        case "3":
          return "Scissors";
        default:
          Console.WriteLine("Invalid Choice, Please select 1, 2, or 3");
          return chooseHand();
      }
    }


    static string getComputerHand()
    {
      int randomNumber = new Random().Next(1, 4);
      string computerHand;

      switch (randomNumber)
      {
        case 1:
          computerHand = "Rock";
          break;
        case 2:
          computerHand = "Paper";
          break;
        case 3:
          computerHand = "Scissors";
          break;
        default:
          Console.WriteLine("Random Number Fail");
          return getComputerHand();
      }
      return computerHand;
    }

    static string DetermineWinner(string userHand, string computerHand)
    {
      if (userHand == computerHand)
      {
        return "It's a tie!";
      }
      else if (
          (userHand == "Rock" && computerHand == "Scissors") ||
          (userHand == "Paper" && computerHand == "Rock") ||
          (userHand == "Scissors" && computerHand == "Paper")
      )
      {
        PlayerWins++;
        return "You Win!";
      }
      else
      {
        ComputerWins++;
        return "You Lose!";
      }
    }

    static void PlayAgain()
    {
      Console.WriteLine("Play again? (y/n)");
      string playAgain = Console.ReadLine().ToLower();

      if (playAgain == "y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Thanks for playing!");
        Environment.Exit(0);
      }
    }
  }
}