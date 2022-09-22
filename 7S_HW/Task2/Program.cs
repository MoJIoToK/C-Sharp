// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите позицию: ");
int[] position = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);

Console.WriteLine();

ProcessArray(array, position);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void ProcessArray(int[,] intArray, int[] pos)
{
    int m = intArray.GetLength(0);
    int n = intArray.GetLength(1);
    int number = 0;

    if (pos[0] < m && pos[1] < n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                number = intArray[pos[0], pos[1]];
            }
        }
    Console.WriteLine($"{number}");
    }
    else Console.WriteLine("Такого числа в массиве нет");
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}