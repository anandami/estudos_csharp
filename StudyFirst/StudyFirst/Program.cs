using System;

namespace StudyFirst {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine("First program using classes:");

            Console.WriteLine("Data of the first person: ");
            //object A
            People A = new People();

            //data
            Console.Write("Name: ");
            A.name = Console.ReadLine();
            Console.Write("Age: ");
            A.age = int.Parse(Console.ReadLine());
            Console.Write("Job: ");
            A.job = Console.ReadLine();
            Console.Write("Salary: ");
            A.salary = double.Parse(Console.ReadLine());


            Console.WriteLine("Data of the second person: ");
            //object B
            People B = new People();

            //data
            Console.Write("Name: ");
            B.name = Console.ReadLine();
            Console.Write("Age: ");
            B.age = int.Parse(Console.ReadLine());
            Console.Write("Job: ");
            B.job = Console.ReadLine();
            Console.Write("Salary: ");
            B.salary = double.Parse(Console.ReadLine());

            //compare
            if (A.age > B.age) {
                Console.WriteLine(A.name + " is the oldest person!");
            } else {
                Console.WriteLine(B.name + " is the oldest person!");
            }

            //average of salary
            double avg = (A.salary + B.salary) / 2;
            Console.WriteLine("The average wage is " + avg);
        }
    }
}
