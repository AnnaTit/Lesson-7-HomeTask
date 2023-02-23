// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10.0;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
Console.Write("Input number of lines:  ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Input a line: ");
int index1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input a column: ");
int index2 = Convert.ToInt32(Console.ReadLine()) - 1;
int size1 = 5;
int size2 = 5;
Random random = new Random();
int[,] arr = new int[size1, size2];
Console.WriteLine("Original array: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(0, 10);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}
if (index1 < 0 | index1 > arr.GetLength(0) - 1 | index2 < 0 | index2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("Element doesn't exist  ");
}
else
{
    Console.WriteLine("Element is = {0}", arr[index1, index2]);
}
Console.ReadLine();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int size1 = 5;
int size2 = 5;
Random random = new Random();
int[,] arr = new int[size1, size2];
Console.WriteLine("Original array: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(0, 10);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine("----------");
Console.Write("Arithmetic mean in columns: ");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }

    Console.Write($"{sum / arr.GetLength(0)}; ");
}
Console.ReadLine();