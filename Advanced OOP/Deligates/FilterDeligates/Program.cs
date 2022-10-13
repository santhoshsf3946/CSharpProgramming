using System;
using System.Collections.Generic;
namespace FilterDeligates;

public delegate bool FilterDeligate (Person p);

public class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person() { Name = "John", Age = 41 };
        Person person2 = new Person() { Name = "Jane", Age = 69 };
        Person person3 = new Person() { Name = "Jake", Age = 12 };
        Person person4 = new Person() { Name = "Ravi", Age = 10 };
        Person person5 = new Person() { Name = "Baskaran", Age = 30 };
        Person person6 = new Person() { Name = "Ganesh", Age = 50 };

        // Create a List Person Objects and fill it
        List<Person> people = new List<Person>(){ person1, person2, person3, person4, person5, person6 };

        // Invoke DisplayPeople using appropriate delegate 
        DisplayPeople("Children", people, IsChild);
        DisplayPeople("Voters", people, IsVoter);
        DisplayPeople("Adults", people, IsAdult);
        DisplayPeople("Seniors", people, IsSenior);
    }

    static void DisplayPeople(string title, List<Person> people, FilterDeligate filter)
    {
        Console.WriteLine("\nPeople in " + title + " list are:");

        foreach (Person person in people)
        {
            if (filter(person))
            {
                Console.WriteLine($"\t{person.Name}, is {person.Age} years old");
            }
        }
    }

    static bool IsChild(Person p) { return p.Age < 15; }

    static bool IsVoter(Person p) { return p.Age >= 18; }

    static bool IsAdult(Person p) { return (p.Age >= 18 && p.Age <50); }

    static bool IsSenior(Person p) { return p.Age >= 50; }
}
