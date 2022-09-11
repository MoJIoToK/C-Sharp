// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Первый вариант");
Console.WriteLine("Введите координаты точки А и В через запятую ");

string[] stringNumbers = Console.ReadLine().Split(',');
double[] doubleNumbers = new double [6];
for (int index = 0; index < stringNumbers.Length; index++)  // цикл для заполнения пустого целочисленного массива
    doubleNumbers [index] = Convert.ToInt32(stringNumbers[index]);
double res = Math.Sqrt(Math.Pow(doubleNumbers[0] - doubleNumbers[3], 2) + Math.Pow(doubleNumbers[1] - doubleNumbers[4], 2)+ Math.Pow(doubleNumbers[2] - doubleNumbers[5], 2));
Console.WriteLine($"Расстояние между точками {Math.Round(res, 2)}");

//Second variation:
Console.WriteLine(" ");
Console.WriteLine("Второй вариант");
Console.Write("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int z2 = int.Parse(Console.ReadLine());

double sqrDeltaX = Math.Pow((x1-x2),2);
double sqrDeltaY = Math.Pow((y1-y2),2);
double sqrDeltaZ = Math.Pow((z1-z2),2);

Console.WriteLine($"Длина отрезка = {Math.Round(Math.Sqrt(sqrDeltaX+sqrDeltaY+sqrDeltaZ),2)}");


// Third variation:
Console.WriteLine(" ");
Console.WriteLine("Третий вариант");
Console.WriteLine("Введите координаты первой точки");
string[] values = Console.ReadLine().Split(',');
int X1 = int.Parse(values[0]);
int Y1 = int.Parse(values[1]);
int Z1 = int.Parse(values[2]);

Console.WriteLine("Введите координаты второй точки");
string[] values_2 = Console.ReadLine().Split(',');
int X2 = int.Parse(values_2[0]);
int Y2 = int.Parse(values_2[1]);
int Z2 = int.Parse(values_2[2]);

double result = Math.Round(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2)),2);

Console.WriteLine($"Расстояние между двумя точками в 3D равно: {result}");
