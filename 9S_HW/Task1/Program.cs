// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();

int cons = 10;
Output(cons);

int Output(int constanta)
{
    if (constanta < 2) return 0;
    else
        if (constanta % 2 == 0) Console.Write($"{constanta}, ");
    return Output(constanta - 1);
}


// int cons = 5;
// Output(1, cons);

// void Output (int num, int constanta)
// {
//     if (num == constanta+1) return;
//     if (num % 2 == 0) Console.Write($"{num}, ");
//     Output(num+1, constanta);
// }