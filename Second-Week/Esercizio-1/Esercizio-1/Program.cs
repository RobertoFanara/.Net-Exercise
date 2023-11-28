List<string> userInputList = new List<string>();

Console.WriteLine("Enter 10 values!");


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Enter value {i + 1}: ");
    string? userInput = Console.ReadLine();

    userInputList.Add(userInput);
}


foreach (string input in userInputList)
{
    Console.WriteLine(input);
}