// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


Console.Clear();
Console.WriteLine("Введите размерность массива (число элементов в массиве): ");
int size = int.Parse(Console.ReadLine());

double[] FillArray(int length)
{
    double[] arr = new double[length];
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(-100, 100); 
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}\r\n"); // \r\nConsole.Write($"{arr[i]}, ");
    }
}

double DiffOfMaxAndMin (double [] arr)
{
    double min = arr[0];
    double max = arr[0];
    double dif = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"Маскимальный элемент: {max}");
    Console.WriteLine($"Минимальный элемент: {min}");
    return dif = max - min;
}

double [] array = FillArray(size);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом -> {DiffOfMaxAndMin(array)}");
