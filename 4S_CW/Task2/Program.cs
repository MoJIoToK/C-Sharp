// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine()); 
int number = Math.Abs(number1); 

int GetCount(int number)
{
    int count = 0;
    while (number > 10)
    {
        number = number / 10;
        //Console.WriteLine(number);
        count++;
    }
    return count+1;
}

Console.WriteLine($"{number1} -> {GetCount(number)}");
