int[,] matrix =
{
    {1 ,2, 3, 9},
    {4, 5, 6, 10},
    {7, 8, 9, 8}
};

void ReplaseElemsBySquares(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                table[i, j] = table[i, j] * table[i, j];
            }
        }
    }
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
ReplaseElemsBySquares(matrix);
PrintTable(matrix);
