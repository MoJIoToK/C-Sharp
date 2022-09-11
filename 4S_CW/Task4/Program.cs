// Задача 30: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();
int [] array = new int [8];

void Rand(int [] arr)
{
    int length = arr.Length;
    int index = 0;
    Console.Write("[");
    while (index < length-1)
    //for (int i = 0; i < 8; i++)
    {
        arr[index] = new Random().Next(0,2);
        Console.Write($"{arr[index]},");
        index++;
        
    }
        Console.Write($"{arr[index]}");
    Console.Write("]");
}
Rand(array);

// Второй вариант

// Console.Clear();
// int[] array = new int[12];
// PrintArray(array);
// FillArray(array);

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length) 
//     {
//         collection[index] = new Random().Next(0,2);
//         index++;
//     }    
// }
// void PrintArray(int[] coll)
// {
//     int count = coll.Length;
//     int position = 0;
//     Console.Write("[");
//     while(position < count)
//     {
//         Console.Write($"{(position == 0 ? coll[position] : "," + coll[position])}"); 
//         position++;
//     };
//     Console.WriteLine("]\r\n");
// }

