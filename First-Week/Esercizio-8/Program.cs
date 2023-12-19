Console.WriteLine("Insert a word");
string? word = Console.ReadLine();
string reversedString = "";

for (int i = word.Length - 1; i >= 0; i--){

    if(word == null)
    {
        throw new ArgumentException();
    }

    reversedString += word[i];
}
if ( reversedString.Equals(word))
{
    Console.WriteLine($"The word you inserted '{word}' is palindrome");
}
else
{
    Console.WriteLine($"The word you inserted '{word}' isn't palindrome");


}
