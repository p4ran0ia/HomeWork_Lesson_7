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

int[,] table = new int[4, 5];
FillTable(table);
PrintTable(table);

Console.WriteLine("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > table.GetLength(0) - 1 || n > table.GetLength(1) - 1)
    Console.WriteLine("Нет такой строки или столбца!");
else
    Console.WriteLine($"Значение элемента: {table[m, n]}");