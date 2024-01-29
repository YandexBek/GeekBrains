int SumOfDigits(int num)
{
    if(num == 0)
    {
        return 0;
    }
    int sum = num % 10 + SumOfDigits(num / 10);
    return sum;
}

int res = SumOfDigits(345);
Console.WriteLine(res);