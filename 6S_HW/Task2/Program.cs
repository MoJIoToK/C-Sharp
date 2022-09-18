// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Beep();
Console.Clear();

Console.WriteLine("Первая прямая y=k1*x+b1. Введите k1 и b1 через запятую: ");
string[] strLine1 = Console.ReadLine().Split(',');

Console.WriteLine("Вторая прямая y=k2*x+b2. Введите k2 и b2 через запятую: ");
string[] strLine2 = Console.ReadLine().Split(',');

double[] dLine1 = FillArray(strLine1);
double[] dLine2 = FillArray(strLine2);

double[] resP = new double[2];

bool test = TestOfIntersection(dLine1, dLine2);

if (test == true)
    resP = GetProcess(dLine1, dLine2);
else Console.WriteLine("Линии не пересекаются");

Console.WriteLine($"Первая прямая - ({String.Join(", ", dLine1)}), Вторая прямая - ({String.Join(", ", dLine2)}) -> ({String.Join("; ", resP)})");

Console.WriteLine();

Console.WriteLine($"b1 = {dLine1[1]}, k1 = {dLine1[0]}, b2 = {dLine2[1]}, k2 = {dLine2[0]}  -> ({String.Join("; ", resP)})");

double[] FillArray(string[] strArr)
{
    int count = 0;
    double[] Num = new double[strArr.Length];
    foreach (string el in strArr)
    {
        Num[count] = double.Parse(el);
        count++;
    }
    return Num;
}

bool TestOfIntersection(double[] arr1, double[] arr2)
{
    return dLine1[0] != dLine2[0];
}

double[] GetProcess(double[] arr1, double[] arr2)
{
    double[] resPoint = new double[2];
    resPoint[0] = (dLine2[1] - dLine1[1]) / (dLine1[0] - dLine2[0]);
    resPoint[1] = (dLine1[0] * resPoint[0]) + (dLine1[1]);
    //    Console.Write($" -> {String.Join("; ", resPoint)}");
    return resPoint;
}
