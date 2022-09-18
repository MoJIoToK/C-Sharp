// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Beep();
Console.Clear();

int [] FillArray(string[] strArr)
{
    int count = 0;
    int [] Num = new int[strArr.Length];
    foreach (string el in strArr)
    {
        Num[count] = int.Parse(el);
        count++;
    }
    return Num;
}

int GetProcess(int[] arr)
{
    int i = 0;
    int num = 0;
    foreach (int el in arr)
    {
        if (arr[i] > 0) num++;
        i++;
    }
    return num;
}

Console.WriteLine("Введите числа: ");
string[] strNumbers = Console.ReadLine().Split(',');

int[] intNumber = FillArray(strNumbers);
Console.WriteLine($"{String.Join(", ", intNumber)}  ->  {GetProcess(intNumber)}");

