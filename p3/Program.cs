using System;

Person person = new Person();

person.NameAge();
person.Print();
person.GetOldestMember();

class Person
{
    public int N = int.Parse(Console.ReadLine());
    public string[] name = new string[100];
    public int[] age = new int[100];

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

    public void GetOldestMember()
    {
        Console.WriteLine();
        int max = age[0];
        for(int i = 0; i < N; i++)
        {
            if(max < age[i])
                max = age[i];
        }

        for (int i = 0; i < N; i++)
        {
            if (max == age[i])
            Console.WriteLine($"Name: {name[i]}\tAge: {age[i]}");
        }
    }
}