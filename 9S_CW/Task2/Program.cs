// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();

Console.Write("Введите нижнюю границу диапазона: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите верхнюю границу диапазона: ");
int n = int.Parse(Console.ReadLine());

if (n > m) OutputIncrease(m, n);
else
{
    Console.WriteLine("Введены неправильные границы диапазона, но не переживайте, я это учел!");
    OutputIncrease(n, m);
}
void OutputIncrease(int num, int constanta)
{
    if (num == constanta + 1) return;
    if (num < constanta) Console.Write($"{num}, ");
    else if (num == constanta) Console.Write($"{num}");
    OutputIncrease(num + 1, constanta);
}
