Console.WriteLine("Inserisci il primo numero");

string? firstNumber = Console.ReadLine();

int numberA = int.Parse(firstNumber);

Console.WriteLine("Adesso inserisci il secondo numero");

string? secondNumber = Console.ReadLine();

int numberB = int.Parse(secondNumber);

Console.WriteLine("Ora dichiara l'operatore (+, -, *, /)");

string? op = Console.ReadLine();


int result;

switch (op)
{
    case "+":
        result = numberA + numberB;
        Console.WriteLine($"Bravissimo, il risultato è: {result}");
        break;

    case "-":
        result = numberA - numberB;
        Console.WriteLine($"Bravissimo, il risultato è: {result}");
        break;

    case "*":
        result = numberA * numberB;
        Console.WriteLine($"Bravissimo, il risultato è: {result}");
        break;

    case "/":
        result = numberA / numberB;
        Console.WriteLine($"Bravissimo, il risultato è: {result}");
        break;
}




