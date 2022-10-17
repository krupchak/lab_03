using System;

Person pesho = new Person();
pesho.Print();

int age = int.Parse(Console.ReadLine());
Person gosho = new Person(age);
gosho.Print();

string name = Console.ReadLine();
int age1 = int.Parse(Console.ReadLine());
Person stamat = new Person(name, age1);
stamat.Print();

class Person
{
    private string name;
    private int age;

    public Person() { name = "No name"; age = 1; }
    public Person(int a) { name = "No name"; age = a; }
    public Person(string n, int a) { name = n; age = a; }

    public void Print()
    {
        Console.WriteLine($"Name: {name}\tAge: {age}");
    }
}