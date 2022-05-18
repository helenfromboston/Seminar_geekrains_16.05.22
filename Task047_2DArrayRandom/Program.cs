// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 1);
        }
    }
}

void Print(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк для двумерного массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов для двумерного массива: ");
int n = int.Parse(Console.ReadLine());

double[,] mass = new double[m, n];

FillArray(mass);
Print(mass);