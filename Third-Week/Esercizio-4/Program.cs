using System.Collections.Immutable;

Random random = new Random();

var numbers = Enumerable.Range(0, 1000).Select(n => random.Next(0, 1001));
var sortedNumbers = numbers.OrderBy(n => n, new intComparer());

foreach (var number in sortedNumbers) 
{ 
    Console.WriteLine(number); 
}

//This is the custom comparer

public class intComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        int xLength = x.ToString().Length;
        int yLength = y.ToString().Length;

        return xLength.CompareTo(yLength);
    }
}