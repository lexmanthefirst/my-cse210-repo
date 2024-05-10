using System;
using System.Collections.Generic;
// using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Person p1 = new Person();
        // p1._firstName = "John";
        // p1._lastName = "Doe";
        // p1._age = 25;

        // Person p2 = new Person();
        // p2._firstName = "Joahnnu";
        // p2._lastName = "Dorobucci";
        // p2._age = 35;

        // List<Person> people = new List<Person>();
        // people.Add(p1);
        // people.Add(p2);

        // foreach (Person p in people)
        // {
        //     Console.WriteLine($"{p._firstName} {p._lastName} is {p._age} years old");
        // }

        // SaveToFile(people);

        List<Person> newPeople = ReadFromFile();
        foreach (Person p in newPeople)

        {
            Console.WriteLine(p._lastName);
            // Console.WriteLine($"{p._firstName} {p._lastName} is {p._age} years old");
        }


    }

    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to file...");
        string filename = "people.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine($"{p._firstName}~~{p._lastName}~~{p._age}");
            };

        }
    }

    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading List from file...");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {

            /*
            Console.WriteLine(line);
             
             Line will read like this:

             John~~Doe~~25
             Joahnnu~~Dorobucci~~35
            */
            string[] parts = line.Split("~~");
            Person newPerson = new Person();
            newPerson._firstName = parts[0];
            newPerson._lastName = parts[1];
            newPerson._age = int.Parse(parts[2]);

            people.Add(newPerson);
        }

        return people;
    }

}