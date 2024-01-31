void GetNumInSection(int minNum, int maxNum)
{
    if (minNum <= maxNum)
    {
        Console.Write($"{minNum} ");
        GetNumInSection(minNum + 1, maxNum);
    }
}

Console.WriteLine("Введите значение M:");
int M = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int N = Int32.Parse(Console.ReadLine());
GetNumInSection(M, N);
