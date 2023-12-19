List<int> numberList5 = new List<int> { 1, 2, 4, 4, 3, 9, 8, 7, 65 };
int result1 = numberList5.FirstOrDefault(x => x == 3);
int result2 = numberList5.FirstOrDefault(x => x > 5);
int result3 = numberList5.FirstOrDefault(x => x < 5);
int result4 = numberList5.FirstOrDefault(x => x > 81); // Restituisce 0 perche la condizione non viene soddisfatta visto che non esiste nessun numero maggiore di 81
Console.WriteLine($"FirstOrDefault:\n{result1}\n{result2}\n{result3}\n{result4}");