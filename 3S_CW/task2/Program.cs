// 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите четверть: "); // Приглашение ко вводу дня недели
int number = int.Parse(Console.ReadLine());


if (x > 0 && y > 0) Console.WriteLine("1 четверть");
if (x < 0 && y > 0) Console.WriteLine("2 четверть");
if (x < 0 && y < 0) Console.WriteLine("3 четверть");
if (x > 0 && y < 0) Console.WriteLine("4 четверть");

// Second variation:
// Console.WriteLine("Введите номер четверти");
// int a = int.Parse(Console.ReadLine());
// if (a > 4)
// {
//     Console.WriteLine("вы за диапозоном");
// }
// else
// {
//     if ( a == 1)
// {
//     Console.WriteLine("от 0 до y, от 0 до x");
// }
// if (a == 2)
// {
//   Console.WriteLine("от 0 до y, от -x до 0");
// }
// if (a == 3)
// {
//   Console.WriteLine("от -y до 0, от -x до 0");
// }
// if (a == 4)
// {
//   Console.WriteLine("от -y до 0, от 0 до x");
// }
// }
