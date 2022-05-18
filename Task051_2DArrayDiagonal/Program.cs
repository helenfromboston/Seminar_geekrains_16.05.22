// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int m = 4, n = 3;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}

int sum = 0;
int min = mass.GetLength(0);
if (mass.GetLength(0) > mass.GetLength(1)) min = mass.GetLength(1);

for (int i = 0; i < min; i++)
{
    sum = sum + mass[i, i];
}

Console.WriteLine();

Console.WriteLine(sum);