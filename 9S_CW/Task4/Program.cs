// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// 1. S = 1
// 2. S = S*a
// b. ..=

Console.Clear();

int numberA = 3;
int numberB = 0;
int res = 1;

res = MyPow(numberA, numberB, 1);
Console.WriteLine($"{res}");

int MyPow(int numA, int numB, int result)
{
    if (numB == 0) return result;
    else
    {
        result = result * numA;
        numB--;
        return MyPow(numA, numB, result);
    }
}