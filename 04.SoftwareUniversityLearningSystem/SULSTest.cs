using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class SULSTest
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Trainer trainer = new Trainer("Trainer", "Trainer", 35);
        Console.WriteLine(trainer);
        JuniorTrainer juniorTrainer = new JuniorTrainer("Juniour", "Trainer", 24);
        Console.WriteLine(juniorTrainer);
        SeniorTrainer seniorTrainer = new SeniorTrainer("Seniour", "Treiner", 37);
        Console.WriteLine(seniorTrainer);

        trainer.CreateCourse("OOP");
        juniorTrainer.CreateCourse("C# Advanced");
        seniorTrainer.CreateCourse("Java Basics");
        seniorTrainer.DeleteCourse("C# Advanced");
        Console.WriteLine();

        DropoutStudent dropoutStudent = new DropoutStudent("Droped", "Student", 15, 123456789, 2.00, "Poor evaluations!");
        dropoutStudent.Reapply();

        List<Person> people = new List<Person>
        {
            new Person("Person", "Chovekov", 22),
            new Student("Studen", "Uchenolubkov", 25, 987654321, 6.00),
            new GraduateStudent("Graduate", "Kasmetliikov", 31, 111222333, 4.32),
            new CurrentStudent("Pesho", "Typoto", 23, 951357456, 3.25, "OOP"),
            new CurrentStudent("Mariika", "Luboznatelnikova", 36, 731943567,5.50, "C# Advanced"),
            new OnlineStudent("Student", "Rabotnikov", 35, 359751286, 4.5, "OOP"),
            new OnlineStudent("Goliam", "Marzel", 45, 789135761, 5.15, "Java Basics"),
            new OnsiteStudent("Uchenik", "Bezrabotnikov", 19, 987456321, 4, "OOP", 5),
            new OnsiteStudent("Petrunka", "Kiflova", 23, 666444555, 4.25, "PHP", 10)
        };
        people.Add(trainer);
        people.Add(juniorTrainer);
        people.Add(seniorTrainer);
        people.Add(dropoutStudent);

        List<CurrentStudent> onlyCurrentStudents = people.Where(student => student is CurrentStudent).ToList().Cast<CurrentStudent>().ToList();
        var sortedStudents = onlyCurrentStudents.Where(student => student is CurrentStudent).OrderBy(student => student.AverageGrade);

        Console.WriteLine();
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }
    }
}
