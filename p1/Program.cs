using System;

Person pesho = new Person();
Person gosho = new Person("Gosho", 18);
Person1 stamat = new Person1 { name = "Stamat", age = 43 };

pesho.Name();
pesho.Age();
pesho.Print();
gosho.Print();
stamat.Print();

class Person
{
    private string name;
    private int age;

    public Person() { }
    public Person(string n, int a) { name = n; age = a; }

    public void Name()
    {
        name = Console.ReadLine();
    }
    public void Age()
    {
        age = int.Parse(Console.ReadLine());
    }

    public void Print()
    { 
        Console.WriteLine($"Name: {name}\tAge: {age}");
    }
}

class Person1
{
    public string name;
    public int age;

    public void Print()
    {
        Console.WriteLine($"Name: {name}\tAge: {age}");
    }
}