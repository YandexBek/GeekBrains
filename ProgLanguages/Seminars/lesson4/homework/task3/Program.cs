int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}

void ReversArray(int[] arr)
{
     int firstNumber = 0;
     int lastNumber = arr.Length - 1;
     while(firstNumber < lastNumber)
     {
        int mind = arr[firstNumber];
        arr[firstNumber] = arr[lastNumber];
        arr[lastNumber] = mind;
        firstNumber++;
        lastNumber--;
     }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e}, ");
    }
    Console.Write(";");
}

Console.WriteLine("size:");
int n = Int32.Parse(Console.ReadLine());
int[] arr = CreateArray(n);
PrintArray(arr);
ReversArray(arr);
PrintArray(arr);