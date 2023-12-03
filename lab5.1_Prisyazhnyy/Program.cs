//сборник задач/тема 5/подтема 5.1/высокий уровень/вариант 24

using System;

try
{
    Console.WriteLine("Введите текст: ");
    char[] mas = Console.ReadLine().ToCharArray();
    int kolSpace = 0;
    int x = 0, p = 0, j = 0;
    Console.WriteLine("Введите длину слов для сравнения: ");
    int WordLength = int.Parse(Console.ReadLine());
    for (int i = 0; i < mas.Length; i++) if (mas[i] == ' ') kolSpace++;
    char[][] array = new char[kolSpace + 1][];
    for (int i = 0; i < kolSpace + 1; i++)
    {
        while (mas[x] != ' ' && x + 1 <= mas.Length - 1) x++;
        x = i == kolSpace ? x + 1 : x;
        p = x - j;
        array[i] = new char[p];
        for (int z = 0; j < x; z++)
        {
            array[i][z] = mas[j];
            j++;
        }
        j++; x++;
    }
    x = 0; j = 0; p = 0;
    int kolStr = 0;
    for (int i = 0; i < kolSpace + 1; i++)
    {
        if (array[i].Length == WordLength)
        {
            kolStr++;
            p += kolStr - 1;
        }
    }
    if (kolStr > 1)
    {
    int[,] masNum = new int[p,3];
    while (x < kolStr)
    {
    while (array[x].Length != WordLength) x++;
        for (int i = 0; x < (i = i <= x ? x + 1 : i + 1) && i <= kolSpace;)
        {
            if (array[i].Length != WordLength) continue;
            else
            {
                p = 0;
                for (int z = 0; z < WordLength; z++)
                {
                    for (int h = 0; h < WordLength; h++)
                    {
                        if (array[x][z] == array[i][h]) { p++; break; }
                    }
                }
                for (int z = 0; z < WordLength; z++)
                {
                    for (int h = 0; h < WordLength; h++)
                    {
                        if (array[x][h] == array[i][z]) { p++; break; }
                    }
                }
                masNum[j, 0] = WordLength * 2 - p;
                masNum[j, 1] = x;
                masNum[j, 2] = i;
                j++;
            }
        }
        x++;
    }
    p = 0; x = 0;
    for (int i = 0; i < masNum.GetLength(0); i++)
    {
        x = x < masNum[i,0] ? masNum[i, 0] : x;
        p = x > masNum[i, 0] ? p : i;
    }
        Console.WriteLine("Максимальное расстояние между словами: ");
        for (int i = 0; i < WordLength; i++) Console.Write(array[masNum[p,1]][i]);
        Console.WriteLine();
        for (int i = 0; i < WordLength; i++) Console.Write(array[masNum[p,2]][i]);
        Console.WriteLine();
        Console.WriteLine("Количество пробелов: " + masNum[p, 0]);
        return;
    }
    Console.WriteLine("нету подходяших слов");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}