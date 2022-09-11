// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int Rate(int numA, int numB)
{
    int res = numA;
    int i = 0;
    while (i < numB-1)
    {
        res = res * numA;
        i++;
    }
    return res;
}

Console.WriteLine("Введите число А");
int NumberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int NumberB = int.Parse(Console.ReadLine());

Console.WriteLine($"Число А в степени В равно - {Rate(NumberA, NumberB)}");



