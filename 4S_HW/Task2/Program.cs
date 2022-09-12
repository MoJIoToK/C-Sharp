// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("ВАРИАНТ 1");
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int SumDigit(int num)
{
    int amountDigit = Convert.ToString(num).Length;
    int index = 0;
    int temp = 0;
    int result = 0;
    while (index < amountDigit)
    {
        temp = num - num % 10;
        result = result + (num - temp);
        num = num / 10;
        index++;
    }
    return result;
}
Console.WriteLine($"Сумма цифр числа {number} -> {SumDigit(number)}");

// Второй вариант

Console.WriteLine(" ");
Console.WriteLine("ВАРИАНТ 2");
Console.WriteLine("Введите число: ");
int Number1 = int.Parse(Console.ReadLine());

int SumDigit2(int Num1)
{
    int res = 0;
    while (Num1 > 0)
    {
        res = res + Num1 % 10;
        Num1 = Num1 / 10;
    }
    return res;
}
Console.WriteLine($"Сумма цифр числа {Number1} -> {SumDigit2(Number1)}");
