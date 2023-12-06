using Esercizio_7;

ClassProva Class1 = new ClassProva();

Class1.Id = 2;

//Class1.Name = "Test";     <-- Ci darà errore a causa del livello di protezione. (Private)

string? name = Console.ReadLine();

if (name == null)
{
    throw new InvalidOperationException();
}

Class1.SetPrivateString(name);

Console.WriteLine(Class1.GetPrivateString());

Console.WriteLine(Class1.Id);

//Class1.IsPublic = false;     <-- Ci darà errore a causa del livello di protezione. (Protected)

if (Class1.Id == 1)
{
    Class1.SetProtectedBool(true);
}
else
{
    Class1.SetProtectedBool(false);
}

Class1.GetProtectedBool();