using System.Diagnostics.Tracing;
using System.Threading.Channels;
Console.WriteLine("Write some words, some of this repeatedly");
File.WriteAllText("file.txt", Console.ReadLine());

string[] lines = File.ReadAllLines("file.txt");
Dictionary<string,int> map = new Dictionary<string,int>(StringComparer.OrdinalIgnoreCase);

Console.WriteLine("Word Counter:");

foreach (string line in lines)
{   
    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

   foreach (var word in words)
   {
       if (map.ContainsKey(word))
        {
            map[word] = map[word] + 1;
        } 
       else
        {
            map.Add(word, 1 );
        }
   }
    foreach (var pair in map)
    {
        Console.WriteLine($"You Wrote '{pair.Key}' {pair.Value} Times");
    }

}

