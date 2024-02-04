int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

int m = 2;
int n = 1;
int result = AckermannFunction(m, n);
Console.WriteLine(result);