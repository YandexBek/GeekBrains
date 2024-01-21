int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

bool IsSimple(int n)
{
    for(int i = 2; i < n; i++)
    {
        if(n % i == 0)
        {
            return false;
        }
    }
    return true;
}

int GetPrimeQuantity(int[] array)
{
    int countPrimes = 0;
    foreach(int e in array)
    {
        bool res = IsSimple(e);
        if(res == true)
        {
            countPrimes = countPrimes + 1;
        }
    }
    return countPrimes;
}

Console.WriteLine("size:");
int n = Int32.Parse(Console.ReadLine());
int [] arr = CreateArray(n);
int count = GetPrimeQuantity(arr);
Console.WriteLine(count);