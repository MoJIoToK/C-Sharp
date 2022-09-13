﻿
void FillArray(int [] collection) // метод, collection - имя аргумента
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //void - метод который ничего не возвращает, return not use
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10]; // создай новый массив с 10 элементами

FillArray(array);
//array[4] = 4; // принудительная вставка 4
//array[7] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);
// Сначала создали массив из 10 элементов, затем в методе заполнили их рандомными 10 значениями, а после в методе распечатали