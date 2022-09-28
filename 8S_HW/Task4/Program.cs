// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int axisX = 2;
int axisY = 2;
int axisZ = 2;


int[,,] array = GetArray(axisX, axisY, axisZ, 10, 100);
PrintArray(array);

int[,,] GetArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x, y, z];
    int r = new Random().Next(-minValue, maxValue);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = r + (new Random().Next(minValue, maxValue + 1));
            }

        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($" {inArray[i, j, k]} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

//https://github.com/Herobrina2306/Dz8