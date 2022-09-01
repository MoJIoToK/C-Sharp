// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()); // для перевода string в число

Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()); // для перевода string в число

if (number1 == number2 * number2)
{
     Console.Write("Первое число является квадратом второго числа");
}

else
{
    Console.Write("Первое число не является квадратом второго числа");
}
