using System;

Employee person = new Employee();

person.NameAge();
person.Print();
person.Salary();

class Employee
{
    public int N = int.Parse(Console.ReadLine());
    public string[] name = new string[100];
    public float[] salary = new float[100];
    public string[] position = new string[100];
    public string[] department = new string[100];
    public string[] email = new string[100];
    public int[] age = new int[100];

    public Employee() { }

    public void NameAge()
    {
        for (int i = 0; i < N; i++)
        {
            name[i] = Console.ReadLine();
            salary[i] = float.Parse(Console.ReadLine());
            position[i] = Console.ReadLine();
            department[i] = Console.ReadLine();
            email[i] = Console.ReadLine();
            age[i] = int.Parse(Console.ReadLine());
        }
    }

    public void Print()
    {
        for (int i = 0; i < N; i++)
            Console.WriteLine($"{name[i]} {salary[i]} {position[i]} {department[i]} {email[i]} {age[i]}");
    }

    public void Salary()
    {
        Console.WriteLine();
        float max = 0, sum = 0, avg = 0;
        int k = 1;
        for (int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                if (department[i] == department[j])
                {
                    sum += salary[i];
                    k++;
                }
            }
        }
        Console.WriteLine(sum / k);
    }
}