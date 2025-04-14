internal class Program
{
  private static void Main()
  {
    Console.WriteLine("Howdily-doodily, neighborino!");
    string userHand = ChooseHand();
  }
  static string ChooseHand()
  {
    Console.WriteLine("Choose A Hand");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");
    string userInput = Console.ReadLine();
    return "";
  }
}