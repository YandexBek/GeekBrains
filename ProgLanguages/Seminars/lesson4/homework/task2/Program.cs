int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int CountEvenElements(int[] arr)
{
    int count = 0;
    foreach(int e in arr)
    {
        if(e % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

// void PrintEvenElements(int[] arr)
// {
//     Console.Write("чётные:");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             Console.Write($"{arr[i]} ");
//         }
//     }
// }

void PrintArray(int[] arr)
{
    Console.Write("массив:");
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
Console.WriteLine("size:");
int n = Int32.Parse(Console.ReadLine());
int[] arr = CreateArray(n);
//PrintEvenElements(arr);
int count = CountEvenElements(arr);
PrintArray(arr);
Console.Write(count);