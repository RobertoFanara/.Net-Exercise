int[] numbers =
{
   5,
   6,
   2,
   4,
   1,
};

numbers[3] = 3;

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Object[] newArray =
{
    5,
    "hello",
    27,
};

foreach (var ob in newArray)
{
    Console.WriteLine(ob);
}
Console.WriteLine();


Object[] newArray2 = new Object[6];


Array.Copy(numbers, newArray2, 3);
Array.Copy(newArray, 0, newArray2, 3, 3);

foreach (var ob in newArray2)
{
    Console.WriteLine(ob);
}