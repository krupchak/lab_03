using System;

Engine engine = new Engine();
Car car = new Car();

engine.Date();
engine.Print();
Console.WriteLine();
car.Date1();
car.Print1();

class Engine
{
    public int N = int.Parse(Console.ReadLine());
    public string[] model = new string[100];
    public int[] power = new int[100];
    public int[] displacement = new int[100];
    public string[] efficiency = new string[100];

    
    public Engine() { }

    public void Date()
    {
        for (int i = 0; i < N; i++)
        {
            model[i] = Console.ReadLine();
            power[i] = int.Parse(Console.ReadLine());
            displacement[i] = int.Parse(Console.ReadLine());
            efficiency[i] = Console.ReadLine();
        }
    }

    public void Print()
    {
        for (int i = 0; i < N; i++)
            Console.WriteLine($"{model[i]} {power[i]} {displacement[i]} {efficiency[i]}");
    }
};

class Car : Engine
{
    public int M = int.Parse(Console.ReadLine());
    public string[] modelC = new string[100];
    public string[] engine = new string[100];
    public int[] weight = new int[100];
    public string[] color = new string[100];

    public Car() { }

    public void Date1()
    {
        for (int i = 0; i < M; i++)
        {
            modelC[i] = Console.ReadLine();
            engine[i] = Console.ReadLine();
            weight[i] = int.Parse(Console.ReadLine());
            color[i] = Console.ReadLine();
        }
    }

    public void Print1()
    {
        for (int i = 0; i < M; i++)
        {
            Console.WriteLine($"{modelC[i]}:");
            Console.WriteLine($"\t{engine[i]}:");
            for(int j=0; j<N; j++)
            {
                if(engine[i] == engine[j])
                {
                    Console.WriteLine($"\tPower: {power}");
                    Console.WriteLine($"\tDisplacement: {displacement}");
                    Console.WriteLine($"\tEfficiency: {efficiency}");
                }
            }
            Console.WriteLine($"\tWeight: {weight[i]}");
            Console.WriteLine($"\tColor: {color[i]}");
        }
    }
}