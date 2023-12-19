

using Esercizio18;

var random = new Random();
List<Student> students = new List<Student>();
string[] names = new string[] { "Franco", "Alma", "Roberto", "Elisa", "Francesco", "Giorgia", "Patrizio", "Letizia" };
Console.WriteLine("Studenti della classe :");

for (int i = 0; i < 10; i++)
{
    string Name = names[random.Next(0, names.Length)];
    int Grade = random.Next(0, 11);
    Student student = new Student(Name, Grade);
    students.Add(student);
    Console.WriteLine(student);


}

int sum = 0;
foreach (Student student in students)
{
    sum += student.Grade;
}
double avarageGrade = (double) sum / students.Count;
Console.WriteLine("La media voti degli studenti è " + avarageGrade + "\n");
Console.WriteLine("I migliori studenti sono :");

int maxGrade = 0;
foreach (Student student in students)
{
    if (student.Grade > maxGrade)
    {
        maxGrade = student.Grade;
        
    
    }
}

foreach (Student student in students)
{
    if ((student.Grade == maxGrade))
    {
        Console.WriteLine(student);
    }
}
