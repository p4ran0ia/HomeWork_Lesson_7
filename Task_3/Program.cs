void FillTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
            tab[i, j] = new Random().Next(1, 10);
    }
}

void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
            Console.Write($"{tab[i, j]} ");
        Console.WriteLine();
    }

}

void Average(int[,] tab)
{
    for (int j = 0; j < tab.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < tab.GetLength(0); i++)
        {
            sum += tab[i, j];
        }
        double aver = sum / tab.GetLength(0);
        Console.WriteLine($"Среднее арифметическое {j + 1} столбца = {aver}");
    }
}

int[,] table = new int[4, 5];
FillTable(table);
PrintTable(table);
Average(table);


