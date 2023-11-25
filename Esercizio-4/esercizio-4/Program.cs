class ReverseString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input something!");
        string? str = Console.ReadLine() ;
        char[] stringArray = str.ToCharArray();
        Array.Reverse(stringArray);
        string reversedStr = new string(stringArray);
        Console.Write($"Actual String is : {str} \n");
        Console.Write($"Reversed String is : {reversedStr} ");
    }
}
