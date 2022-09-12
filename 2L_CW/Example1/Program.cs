// See https://aka.ms/new-console-template for more information
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 1;
int a2 = 2;
int a3 = 6;
int b1 = 8;
int b2 = 4;
int b3 = 4;
int c1 = 13;
int c2 = 23;
int c3 = 313;

//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3)); // можно и так

Console.Write("max = ");
Console.WriteLine(max);