Queue<string> myQueue =  new Queue<string>();

while (true)
{
    Console.WriteLine("Cosa vuoi fare ?");
    Console.WriteLine("[1] - Queue");
    Console.WriteLine("[2] - Dequeue");
    Console.WriteLine("[3] - Peek");

    string? userOption = Console.ReadLine();

    switch (userOption)
    {
        case "1":
            Console.WriteLine("Imposta una stringa da mettere in Queue");
            string? userInput = Console.ReadLine();
            myQueue.Enqueue(userInput);
            break;

        case "2":
            if (myQueue.Count == 0)
            {
                Console.WriteLine("Queue vuota, impossibile inizializzare operazione.");
            }
            else
            {
                string inputDequeued = myQueue.Dequeue();
                Console.WriteLine($"stringa Dequeued: {inputDequeued}");
            }
            break;

        case "3":
            if (myQueue.Count == 0)
            {
                Console.WriteLine("Queue vuota, impossibile inizializzare operazione.");
            }
            else
            {
                string inputPeeked = myQueue.Peek();
                Console.WriteLine($"stringa Peeked: {inputPeeked}");
            }
            break;

        default:
            Console.WriteLine("Input non valido, riprovare!");
            break;
    }
}