while (true)
{
    Console.Write("Для выхода введите (q) или число: ");
    string str = Console.ReadLine();
    if (str == "q")
    {
        Console.Write("стоп");
        break;
    }
    int n = Int32.Parse(str);
    int number = SumElements(n);
    if(n % 2 == 0)
    {
        Console.Write("стоп");
        break;
    }
    else
    {
        Console.Write("сумма цифр в числе должно быть четным! ");
    }

}

int SumElements(int num)
{
    int i = 1;
    int sum = 0;
    while(i <= num)
    {
        sum = sum + num % 10;
        i++;
    }
    return sum;
}