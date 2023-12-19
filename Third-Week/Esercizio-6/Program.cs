Random random = new Random();
var numbers = Enumerable.Range(0, 100).Select(i => random.NextDouble()*1000).ToList();
Console.WriteLine($"La somma iniziale è {numbers.Sum()}");
Console.WriteLine($"La media iniziale è {numbers.Average()}");
Console.WriteLine($"I numeri totali sono {numbers.Count()}");

Console.WriteLine($"Inserisci un numero compreso tra 0 e {numbers.Count}");
string? a = Console.ReadLine();
int skipNumber = int.Parse(a);

Console.WriteLine($"\nInserisci un numero compreso tra 0 e {numbers.Count - skipNumber}");
string? b = Console.ReadLine();
int takeNumber = int.Parse(b);

Console.WriteLine();

var result = numbers.Skip(skipNumber).Take(takeNumber);

Console.WriteLine($"La somma finale è {result.Sum()}");
Console.WriteLine($"La media finale è {result.Average()}");
Console.WriteLine($"Ora i numeri totali sono {result.Count()}");