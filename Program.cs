internal class Program
{
  private static void Main()
  {
    Console.WriteLine("Howdily-doodily, neighborino!");
    string userHand = ChooseHand();
    Console.WriteLine($"You chose: {userHand}");
  }
  static string ChooseHand()
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
        return ChooseHand();
    }
  }
}