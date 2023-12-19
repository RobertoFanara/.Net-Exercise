
Random random = new Random();
var numbers = Enumerable.Range(0,1000).Select(x => random.Next(0,1001)).ToList();

var oddNumbers = from number in numbers
                 where number % 2 != 0
                 orderby number
                 select number;

Console.WriteLine("Odd number list:");
foreach (var item in oddNumbers)
{
    Console.WriteLine(item);
}