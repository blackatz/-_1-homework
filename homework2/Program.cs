// напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.WriteLine("Программа вычисления наибольшего числа.");
Console.WriteLine("Введите первое число: ");
int input1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int input2 = int.Parse(Console.ReadLine()!);

if (input1 < input2)
{
    Console.WriteLine(input2 + " больше");
}

if (input2 < input1)
{
    Console.WriteLine(input1 + " больше");
}
