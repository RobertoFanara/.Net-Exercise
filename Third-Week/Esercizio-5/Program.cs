Random random = new Random();   
var numbers = Enumerable.Range(0,100).Select(i => random.NextDouble()*100).ToList();

Console.WriteLine($"La somma è {numbers.Sum()}");
Console.WriteLine($"La media è {numbers.Average()}");
Console.WriteLine($"I numeri presenti nella lista sono {numbers.Count()}");

