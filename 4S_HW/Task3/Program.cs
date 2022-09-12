// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

Console.WriteLine("Введите числа через запятую: ");
string[] strArray = Console.ReadLine().Split(',');

int[] FillArray(string[] arr)
{
    int length = arr.Length;
    int index = 0;
    int[] intArr = new int[length];

    while (index < length)
    {
        intArr[index] = Convert.ToInt32(arr[index]);
        index++;
    }

    return intArr;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        Console.Write($"{(position == 0 ? col[position] : "," + col[position])}");
        position++;
    }
    Console.WriteLine("]\r\n");
}

int[] resultArray = FillArray(strArray);
if (resultArray.Length != 8)
{
    Console.WriteLine("Введенное число неверно!");
}
else
{
    PrintArray(resultArray);
}

