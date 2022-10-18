// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Программа вычисления всех четных чисел от 1 до N.");
Console.WriteLine("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
int N2 = 2;
int N3 = -2;

if (N < 0)
    while (N3 >= N)
    {
    Console.Write(N3 + " ");
    N3 = N3 - 2;   
    }

else
    while (N2 <= N)
    { 
        Console.Write(N2 + " ");
        N2= N2 + 2;
    }
