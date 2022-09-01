// Напишите программу, которая на вход принимает число и 
// выдаёт его квадрат (число умноженное на само себя)

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()); // для перевода string в число
//int number = Console.ReadLine(); пробовал 
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}"); // для того чтобы был записан текст и переменная use $ и {}

int sqr1 = Convert.ToInt32(Math.Pow(number,2)); //содержит тип double, поэтому Convert.ToInt32()
Console.WriteLine($"Квадрат числа {number} равен {sqr1}");


