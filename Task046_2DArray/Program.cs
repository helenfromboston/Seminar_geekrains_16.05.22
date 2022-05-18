// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int m = 3, n = 4;
int[,] mass = new int[m, n];

Console.WriteLine(mass.Length);
Console.WriteLine(mass.GetLength(0));
Console.WriteLine(mass.GetLength(1));

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(-100, 100);
    }
}

Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}