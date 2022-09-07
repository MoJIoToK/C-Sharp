// Метод 1

void Method1() // ничего не принимает, ничего не возвращает
{
    Console.WriteLine("Метод 1");
    Console.WriteLine("Автор - Николас");
}

Method1();

// Метод 2

void Method2(string msg) // принимает на вход, ничего не возвращают
{
    Console.WriteLine(" ");
    Console.WriteLine("Метод 2");
    Console.WriteLine(msg);
}

Method2("Текст сообщения");

// Метод 2.1

void Method2_1(string msg, int count) // принимает на вход, ничего не возвращают
{
    int i = 0;
    Console.WriteLine(" ");
    Console.WriteLine("Метод 2.1");
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method2_1(msg: "Текст сообщения", count: 4); // если именованные, то необязательно по порядку

// Метод 3 ничего не принимают, но что-то возвращают

int Method3() // принимает на вход, ничего не возвращают
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(" ");
Console.WriteLine("Метод 3");
Console.WriteLine(year);

// Метод 4 что-то принимают, что-то возвращают

string Method4(int count, string c) // принимает на вход, ничего не возвращают
{
    //int i = 0;
    string result = String.Empty;
    
    for ( int i = 0; i < count; i++)
    //while (i < count)
    {
        result = result + c;
    //    i++;
    }
    return result;
}

string res = Method4(10, "QWERTY text, ");
Console.WriteLine(" ");
Console.WriteLine("Метод 4");
Console.WriteLine(res);

// Таблица умножения

for ( int i = 2; i <= 10; i++)
{
    for ( int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}