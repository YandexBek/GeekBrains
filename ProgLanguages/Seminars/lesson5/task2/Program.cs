int[,] matrix =
{
    {1 ,2, 3, 9},
    {4, 5, 6, 10},
    {7, 8, 9, 8}
};

int GetSumOnDiag(int[,] table)
{
    int sum = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += table[i, j];
            }
        }
    }
    return sum;
}

void PrintTable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintTable(matrix);
int[,] table = GetSumOnDiag(matrix);
PrintTable(table);