// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

double Rate(double numA, int numB)
{
    double res = numA;
    int i = 0;
    while (i < numB-1) // минус 1, т.к. выше мы приравниваем переменную уже к числу, а значить умножать нужно не на В, а на В-1
    {
        res = res * numA;
        i++;
    }
    return res;
}
string TryNormalizeSuperscript(int superC, string c)
{
if (superC == 0) c = "⁰";
if (superC == 1) c = "¹";
if (superC == 2) c = "²";
if (superC == 3) c = "³";
if (superC == 4) c = "⁴";
if (superC == 5) c = "⁵";
if (superC == 6) c = "⁶";
if (superC == 7) c = "⁷";
if (superC == 8) c = "⁸";
if (superC == 9) c = "⁹";
return c;
}

Console.WriteLine("Введите число А");
Console.OutputEncoding = System.Text.Encoding.Unicode;
double NumberA = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int NumberB = int.Parse(Console.ReadLine());

string result = "";
Console.WriteLine($"Число А в степени В равно - {Rate(NumberA, NumberB)}, {NumberA}{TryNormalizeSuperscript(NumberB, result)}");




