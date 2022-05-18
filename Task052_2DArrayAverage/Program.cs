// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print(int[,] array)
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

int[,] mass = new int[4, 4];

FillArray(mass);
Print(mass);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое каждого столбца: ");

double sum = 0;

for (int j = 0; j < mass.GetLength(1); j++)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        sum += mass[i, j];
    }
    double avg = sum / mass.GetLength(1);
    Console.Write(Math.Round(avg, 1) + " ");
    sum = 0;
}