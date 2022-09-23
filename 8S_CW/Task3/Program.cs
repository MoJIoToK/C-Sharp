// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

int minVal = 0;
int maxVal = 9;

int[,] array = GetArray(10, 10, minVal, maxVal);
PrintArray(array);
int[,] countArray = CountUnique(array, minVal, maxVal);
Console.WriteLine();
//PrintArray(countArray);
Console.WriteLine();
PrintUnique(countArray);

int[,] CountUnique(int[,] arrayToCount, int min, int max)
{
    int rows = arrayToCount.GetLength(0);
    int columns = arrayToCount.GetLength(1);
    int[,] countUnique = new int[2, 10];
    for (int k = min; k <= max; k++)
    {
        countUnique[0, k] = k;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (arrayToCount[i, j] == k)
                {
                    countUnique[1, k] = countUnique[1, k] + 1;
                }
            }
        }
    }
    return countUnique;
}

void PrintUnique(int[,] arrayToPrint)
{
    int rows = arrayToPrint.GetLength(0);
    int columns = arrayToPrint.GetLength(1);
    for (int l = 0; l < columns; l++)
    {
        if (arrayToPrint[1, l] != 0)
        {
            Console.WriteLine($"{arrayToPrint[0, l]} встречается {arrayToPrint[1, l]} раз(а)");
        }
    }
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
