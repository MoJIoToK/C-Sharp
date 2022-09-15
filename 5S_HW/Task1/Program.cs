// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите размерность массива (число элементов в массиве): ");
int size = int.Parse(Console.ReadLine());

int[] FillArray(int length)
{
    int[] arr = new int[length];
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(100, 1000); 
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}\r\n"); // \r\nConsole.Write($"{arr[i]}, ");
    }
}

int CountOfEven (int [] arr )
{
    int number = 0;
    foreach (var element in arr)
    {
        if (element % 2 == 0)
        {
            number++;
        }
    }
    return number;
}

int [] array = FillArray(size);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве -> {CountOfEven(array)}");

 

