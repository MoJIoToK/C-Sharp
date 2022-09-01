//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()); // для перевода string в число

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()); // для перевода string в число

int max = number1;
int min = number2;

if (max < number2)
{
    min = max;
    max = number2;
}

Console.WriteLine($"Большее число равно {max}");
Console.WriteLine($"Меньшее число равно {min}");
