//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;
if (max < number2) max = number2;
if (max < number3) max = number3;

Console.WriteLine($"Большее число равно {max}");


// Конечно я хотел поискать другие варианты решения задачи. Через массив. Но натолкнулся на такую проблему, 
// не знаю как заполнить массив с клавиатуры, чтобы потом вычленить из него цифры для сравнения.

//{
    //string[] i = Console.ReadLine().Split(' '); // в терминале вводится строковый массив, через пробел. Который разбивается на части
    //int a = Convert.ToInt32(i[0]); // в переменную а кладем первое значение, в б второе, в с третье
    //int b = Convert.ToInt32(i[1]); // ToInt32 преобразует значение в 32-битовое целое число
    //int c = Convert.ToInt32(i[2]);
    //Console.WriteLine(Math.Max(a, Math.Max(b, c))); // с помощью встроенной функции производим вычисление max, попарно.
                                                    // подобную функцию писали на лекции)
//}
