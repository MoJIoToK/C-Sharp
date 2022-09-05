// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число "); 
int number1 = int.Parse(Console.ReadLine());
//int number3_1 = Convert.ToInt32(Console.ReadLine()); 

// первый способ:

int a1 = number1 % 100;
int a2 = a1 / 10;

Console.WriteLine(" "); // пропуск строчки после ввода числа
Console.WriteLine("Первый способ:");
Console.WriteLine($"{number1} -> {a2}");

// Второй способ (модификация классной задачи):

int a3 = number1 % 10;
int a4 = number1 / 100;

Console.WriteLine(" "); // Пропуск строчки после вывода первого варианта
Console.WriteLine("Второй способ:");
Console.WriteLine($"{number1} -> {(number1 - (a4 * 100) - a3)/10}");
Console.WriteLine(" "); // Пропуск строчки после вывода второго варианта

// Третий способ (с помощью массива):

string StringNumber = Convert.ToString(number1);
Console.WriteLine("Третий способ:");
Console.WriteLine($"{number1} -> {StringNumber[1]}");
Console.WriteLine(" "); // Пропуск строчки после вывода третьего варианта

