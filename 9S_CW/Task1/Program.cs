// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
//Console.WriteLine("Введите число N: ");

int cons = 10;
Output(1, cons);

void Output (int num, int constanta)
{
    if (num == constanta+1 ) return;
    Console.Write($"{num}, ");
    Output(num+1, constanta);
}