// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Beep();
Console.Clear();

int n = 4;
int[,] array = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= n * n)
{
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++; // проходит нулевую строку слева направо
    else if (i < j && i + j >= array.GetLength(0) - 1) i++; // проходит правый столбец сверху вниз
    else if (i >= j && i + j > array.GetLength(1) - 1) j--; // проходит последнюю строку справо налево
    else i--;// проходит левый столбец снизу вверх
}

PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($"0{array[i, j]}  ");

            else Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}