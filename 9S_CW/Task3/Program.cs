// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

// Console.WriteLine("Введи")

int number = 45;
int summa = 0;

int res = SumOfDigit(number, summa);
Console.WriteLine($"{res}");

int SumOfDigit(int num, int sum)
{
    int temp = num;
    if (num == 0) return sum;
    else 
    {
        num = num / 10;
        sum = sum + temp%10;
        //Console.WriteLine($"{sum}");
    return SumOfDigit(num, sum);
    }
}

// 1. 453 / 10 = 45 
//     453 % 10 = 3
// 2. 45 / 10 = 4
//     45 % 10 = 5
// 3. 4 / 10 = 0
//     4 % 10 = 4