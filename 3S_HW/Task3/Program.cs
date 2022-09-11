// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());

for (int count = 1; count <= Number-1; count++)
{
    Console.Write(Math.Pow(count,3)+",");
}
    Console.Write(Math.Pow(Number,3)); 