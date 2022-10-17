using System;

Person person = new Person();

person.NameAge();
person.Print();
person.Sort();

class Person
{
    public int N = int.Parse(Console.ReadLine());
    private string[] name = new string[100];
    private int[] age = new int[100];

    public Person() { }

    public void NameAge()
    {
        for (int i = 0; i < N; i++)
        {
            name[i] = Console.ReadLine();
            age[i] = int.Parse(Console.ReadLine());
        }
    }

    public void Print()
    {
        for (int i = 0; i < N; i++)
            Console.WriteLine($"Name: {name[i]}\tAge: {age[i]}");
    }

    public void Sort()
    {
        Console.WriteLine();

        for (int i = 0; i < N; i++)
        {
            if (age[i] > 30)
                Console.WriteLine($"Name: {name[i]}\tAge: {age[i]}");
        }
    }
}
