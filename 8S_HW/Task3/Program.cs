// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.Write("Введите количество строк массива 1: ");
int rows1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива 1: ");
int columns1 = int.Parse(Console.ReadLine());

int[,] array1 = GetArray(rows1, columns1, 0, 9);
PrintArray(array1);

Console.Write("Введите количество строк массива 2: ");
int rows2 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива 2: ");
int columns2 = int.Parse(Console.ReadLine());

int[,] array2 = GetArray(rows2, columns2, 0, 9);
PrintArray(array2);

Console.WriteLine();

int [,] productMatrix = ProductMatrixes(array1, array2);
Console.WriteLine("Результат умножения первой матрицы на вторую равен - ");
PrintArray(productMatrix);


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



int[,] ProductMatrixes(int[,] intArray1, int[,] intArray2)
{
    int [,] res = new int[intArray1.GetLength(0), intArray2.GetLength(1)];
    for (int i = 0; i < intArray1.GetLength(0); i++)
    {
        for (int j = 0; j < intArray2.GetLength(1); j++)
        {
            for (int k = 0; k < intArray1.GetLength(1); k++)
            {
                res[i,j] += intArray1[i,k]*intArray2[k,j];
            }
        }
    }
    return res;
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