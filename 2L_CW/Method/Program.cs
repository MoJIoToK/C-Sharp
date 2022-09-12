// See https://aka.ms/new-console-template for more information
int [] array = {1, 12, 31, 4, 15, 4, 16, 17, 18};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // если хотим чтобы цикл прекратился при достижении в первый раз условия. Т.е. если повторяются числа несколько раз, нам покажут индекс первого попавшегося
    }
    index++;
}

