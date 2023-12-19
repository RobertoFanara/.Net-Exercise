var random = new Random();
int maxNumber = 0;
int minNumber = int.MaxValue;

List<int> list = new List<int>();

for (int i = 0; i < 1000; i++)
{
    list.Add(random.Next(0,1001));
}
foreach (var item in list)
{
    if (item < minNumber) { minNumber = item; }
    if (item > maxNumber) { maxNumber = item; }
}

Console.WriteLine($"Max number is: {max}, Min number is: {min}");