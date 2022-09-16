// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 01123
// Если N = 3 -> 011
// Если N= 7-> 01123 5 8
// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
// 20

Console.Clear();

void Fibonacci(double[] array)
{
    int count = 3;
    while (count < array.Length)
    {
        array[count] = array[count - 1] + array[count - 2];
        //Console.Write($"{arr[count]} ");
        count++;
    }
}

int N = new Random().Next(3,10);
double[] arr = new double[N];
arr[0] = 0;
arr[1] = 1;
arr[2] = 1;

Fibonacci(arr);

foreach (double el in arr)
    {
        Console.Write($"{el} ");
    }


// Second Variation
// Console.WriteLine("Введите число: ");
// bool res = uint.TryParse(Console.ReadLine(), out uint num);
// uint[] rem = Fibonacci(num);
// Console.WriteLine(String.Join(" ", rem));

// uint[] Fibonacci(uint N)
// {
//     uint[] fib = new uint[N];
//     fib[0] = 0;
//     fib[1] = 1;
//     for (uint i = 2; i < N; i++)
//     {
//         fib[i] = fib[i - 1] + fib[i - 2];
//     }
//     return fib;
// }


