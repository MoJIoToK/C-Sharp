// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите нижнюю границу диапазона: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите верхнюю границу диапазона: ");
int n = int.Parse(Console.ReadLine());
int summa = 0;

if (n > m) PrintSum(m, n, summa);
else
{
    Console.WriteLine("Введены неправильные границы диапазона, но не переживайте, я это учел!");
    PrintSum(n, m, summa);
}

void PrintSum(int min, int max, int sum)
{
    if (min <= max)
    {
        sum = sum + min;
    }
    else
    {
        Console.Write($"{sum}");
        return;
    }
    PrintSum(min + 1, max, sum);
}

// void PrintSum(int min, int max, int sum)
// {
//     sum = sum + min;
//     if (min > max-1)
//     {
//         Console.Write($"{sum}"); 
//         return;
//     }
//     PrintSum(min + 1, max, sum);
// }