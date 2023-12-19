using Esercizio14;


LinkedList<TrainStation> list = new LinkedList<TrainStation>();
void Start()
{
    TrainStation Firenze = new TrainStation("Firenze", "Via Firenze 9");
    TrainStation Milano = new TrainStation("Milano", "Piazza IV Novembre");
    TrainStation Napoli = new TrainStation("Napoli", "Via Pordenone 2");
    TrainStation Roma = new TrainStation("Roma", "Corso Cavour 15");
    
    list.AddFirst(Milano);
    list.AddLast(Firenze);
    list.AddLast(Roma);
    list.AddLast(Napoli);
}
void PrintTrainRoute()
{
    for (int i = 0; i < list.Count; i++)
    {

        if (i == 0)
        {
            Console.WriteLine($"Start Station -> {list.ElementAt(i)}");

        }
        else if (i == list.Count - 1)
        {
            Console.WriteLine($"End Station -> {list.ElementAt(i)}");

        }
        else
        {
            Console.WriteLine($"Next Station -> {list.ElementAt(i)}");

        }
    }
}

Start();
PrintTrainRoute();
Console.WriteLine("\nMilano station is closed, this is the new route:");
list.RemoveFirst();
list.AddFirst(new TrainStation("Palermo", "Piazza Matteo Boiardo"));
PrintTrainRoute();
Console.WriteLine();
   
    


