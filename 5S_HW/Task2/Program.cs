// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите размерность массива (число элементов в массиве): ");
int size = int.Parse(Console.ReadLine());

int[] FillArray(int length)
{
    int[] arr = new int[length];
    for (int index = 0; index < size; index++)
    {
        arr[index] = new Random().Next(-100, 100); 
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

int SumOfUneven (int [] arr)
{
    int sum = arr[1];
    for (int i = 2; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + arr[i];
        }
    //Console.WriteLine(sum);
    }
    return sum;
}

int [] array = FillArray(size);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях -> {SumOfUneven(array)}");
