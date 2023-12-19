using System.Threading.Channels;

Console.WriteLine($"current Directory {Directory.GetCurrentDirectory()}");
Console.WriteLine("Insert the path of the file you want to open");
string filePath = Console.ReadLine();
try
{
    string content = File.ReadAllText(filePath);
    Console.WriteLine(content);
}
catch (FileNotFoundException)
{
    Console.WriteLine("File not found");
}
catch (Exception ex)     
{
    Console.WriteLine(ex.StackTrace);
}
