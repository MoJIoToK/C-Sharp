﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: "); // Приглашение к вводу числа
int number = int.Parse(Console.ReadLine()); // запоминание введенного числа в переменной

// Самый простой способ. Есть недостаток - последнее число выводит с ","

int index = 2; // минимальное четное число из заданного диапазона это 2. Приравняем вспомогательную переменную к 2. 
                // По сути данная переменная хранит все четные числа по возрастанию

while (number > index) // цикл который пишет по возрастанию числа меньше заданного
{
    Console.Write(index + ", "); // вывод четного числа с ",". Не знаю как написать чтобы последнее число выводилось без запятой
                                // возможно надо выводить в массив 
    index = index + 2;          // переходим к следующему четному числу
}

// Способ высосал из пальца. Мне не очень понравился, т.к. он значительно больше, и требует больше действий

// Сначала мы проверяем четное ли заданное число. Если нет, то мы делаем его четным: 
//if (number % 2 == 0) 
//{
//    number = number;
//}
//else
//{
//    number = number - 1;
//}


//Затем по сути делаем тоже самое что и в первом варианте.
// Выводит значения по убыванию

//while (number >= 2)
//{
//    Console.Write(number + ", ");
//    number = number - 2;
//}
