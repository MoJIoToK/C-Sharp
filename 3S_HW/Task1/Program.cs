// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Первый вариант
Console.WriteLine("Первый вариант");
Console.WriteLine("Введите пятизначное число через пробел: ");

string [] stringNumber = Console.ReadLine().Split(' '); // в терминале вводится строковый массив, через пробел. Который разбивается на части
int index = 0;
int [] intNumber = new int[stringNumber.Length]; // создание целочисленного массива, с тем же размером что и строковый

for (index = 0; index < stringNumber.Length; index++)// цикл для заполнения пустого целочисленного массива
{
    intNumber [index] = Convert.ToInt32(stringNumber[index]); // строковый массив преобразуем в целочисленный
    Console.WriteLine(intNumber [index]);
} 

if (intNumber[4] == intNumber[0] && intNumber[3] == intNumber[1])
{
    Console.WriteLine("Число является палиндромом!");
}
else Console.WriteLine("Число НЕ является палиндромом!");

//Второй вариант
Console.WriteLine(" ");
Console.WriteLine("Второй вариант");
Console.WriteLine("Введите пятизначное положительное число: ");
string stringNumber1 = Console.ReadLine();

if (stringNumber1[4] == stringNumber1[0] && stringNumber1[1] == stringNumber1[3])
{
    Console.WriteLine("Число является палиндромом!");
}
else Console.WriteLine("Число НЕ является палиндромом!");
