﻿string path = "C:/Users/Nick/Desktop/Коля/Geekbrains"; // ужно при копировании знак "\" заменить на "/"
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);

FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
