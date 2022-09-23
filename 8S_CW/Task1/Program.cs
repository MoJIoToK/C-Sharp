// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
// последнюю строку массива.
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] array = GetArray(5,5,0,9);
PrintArray(array);
int[,] swappedArray = SwapRows(array);
Console.WriteLine();
PrintArray(swappedArray);

int[,] SwapRows(int[,] arrayToSwap)
{
    int rows = arrayToSwap.GetLength(0);
    int columns = arrayToSwap.GetLength(1);
    int[] rowsTemp = new int [columns];
    for(int i = 0; i < columns; i++)
    {
        rowsTemp[i] = arrayToSwap[0,i];
        arrayToSwap[0,i] = arrayToSwap[rows - 1,i];
        arrayToSwap[rows - 1,i] = rowsTemp[i];
    }
    //Console.WriteLine(String.Join(", ", rowsTemp));
    return arrayToSwap;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int interimVar = 0;
    if(minValue > maxValue)
    {
        interimVar = maxValue;
        maxValue = minValue;
        minValue = interimVar;
    }
    
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
// void PrintArray(int[,] array)
// {
//     Console.WriteLine("[");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]:F2},\t");
//         }
//         Console.Write("\b\b]\n");
//     }
//     Console.WriteLine("]");
// }
