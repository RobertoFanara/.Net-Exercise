Console.WriteLine("Digit '1' to convert °C in °F or '2' to convert °F in °C ");
string? choice = Console.ReadLine();
Console.WriteLine("Insert the temperature");
string? temp= Console.ReadLine();
double tempNum = double.Parse(temp);
if (choice.Equals("1"))
{
    double tempFahrenheit = (tempNum * 1.8) + 32;

    Console.WriteLine($"{temp}° C correspond to {tempFahrenheit}° F");
}
else if (choice.Equals("2"))
{
    double tempCelsius = (tempNum - 32) * 1.8;
    Console.WriteLine($"{temp}° F correspond to {tempCelsius}° C");
}