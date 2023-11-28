
using System.Reflection.Metadata;

Console.WriteLine("Inserisci il path per il file .txt");

string? filePath = Console.ReadLine();                      //<-- Percoso da copiare "C:\Users\glosi\source\repos\Esercizio-6\Esercizio-6\File.txt".


string[] words = File.ReadAllLines(filePath);


Dictionary<string, int> wordDuplicates = new Dictionary<string, int>();

foreach (string word in words)
{
    if (!wordDuplicates.ContainsKey(word))
    {
        wordDuplicates.Add(word, 1);
    }
    else
    {
        wordDuplicates[word] += 1;
    }
        
}

foreach (string word in wordDuplicates.Keys)
{
    Console.WriteLine($"{word}: {wordDuplicates[word]}");
}
