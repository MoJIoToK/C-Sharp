// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число для первого варианта через пробел"); 

// Первый вариант (мой с использованием массива):

string [] i = Console.ReadLine().Split(' '); // в терминале вводится строковый массив, через пробел. Который разбивается на части
int index = 0;
int [] array = new int[i.Length]; // создание целочисленного массива, с тем же размером что и строковый

for (index = 0; index < i.Length; index++) // цикл для заполнения пустого целочисленного массива
    array [index] = Convert.ToInt32(i[index]); // строковый массив преобразуем в целочисленный

Console.WriteLine(" ");
Console.WriteLine("Первый вариант");

if (i.Length > 2) // проверка что третья цифра в числе есть
{
    Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

// Второй вариант, тоже с массивом, но я его подглядел в интернете. Он значительно проще моего варианта

Console.WriteLine(" ");
Console.WriteLine("Введите число для второго варианта без пробела"); 
int Number1 = Convert.ToInt32(Console.ReadLine()); // запись числа в переменную
string StringNumber1 = Convert.ToString(Number1); // преобразование переменной в строковый массив

Console.WriteLine(" ");
Console.WriteLine("Второй вариант");

if (StringNumber1.Length > 2)
{
    Console.WriteLine("Третья цифра равна " + StringNumber1[2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}
Console.WriteLine(" ");