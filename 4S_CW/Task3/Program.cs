// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()); 

int Factorial(int num)
{
    int count = num;
    while (count > 1)
    {
        count--;
        num *= count;
        Console.WriteLine(num);
    }
    return num;
}

Console.WriteLine($"{number} -> {Factorial(number)}");

// Второй вариант

// Console.Clear();
// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());
// int number1 = Math.Abs(num);

// int FacterialNum(int kol)
// {
//     int i = 1;
//     int facte = 1;
//     while (i <= kol)
//     {
//         facte = i * facte;
//         i ++;

//     }
//     return facte;
    
// }
// Console.WriteLine($"{num} -> {FacterialNum(number1)}");

// третий вариант
// Console.Clear();
// Console.Write("Введите число: ");
// bool res = uint.TryParse(Console.ReadLine(), out uint number);
// ulong result;
// result = Fact(number);
// if (!res)
// {
//     Console.WriteLine("Что-то пошло не так");
// }
// else
// {
//     Console.WriteLine($"{number}->{result}");
// }

// ulong Fact(uint num) // ulong	0 to 18,446,744,073,709,551,615	Unsigned 64-bit integer	System.UInt64
// {
//     if (num == 0)
//     {
//         return 1;
//     }
//     return num * Fact(num - 1); // 1 * 2 * 3 * ... *(n-1) * n = (n-1)! * n = n!
// }
