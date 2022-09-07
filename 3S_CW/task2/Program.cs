// 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)

Console.Write("Введите номер четверти ");
int x = int.Parse(Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("0 < x <oo  & 0 < y < oo");
}
if (x == 2)
{
    Console.WriteLine("-oo < x < 0 & 0 < y < oo");
}
if (x == 3)
{
    Console.WriteLine("-oo < x < 0 & -oo < y < 0");
}
if (x == 4)
{
    Console.WriteLine("0 < x < oo & -oo < y < 0");
}

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
