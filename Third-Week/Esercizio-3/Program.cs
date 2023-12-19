Random random = new Random();

var ascNumbers = Enumerable.Range(0, 1000).Select(n => random.Next(0,1001)).OrderBy(n=>n);

var descNumbers = ascNumbers.OrderByDescending(n=>n);

Console.WriteLine("1 to 1000 Order: ");
foreach (var asc in ascNumbers)
{
    Console.WriteLine(asc);
}
Console.WriteLine("1000 to 1 Order: ");
foreach (var desc in descNumbers)
{
    Console.WriteLine(desc);
}

