// Задача 24: Напишите программу, которая принимает на вход число (А) и 
//выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {GetSumNums(num)}");

int GetSumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number; // sum+number
        number--; //number = number -1
    }
    return sum;
}
