string GetNumbers(string s)
{
    string numbers = "";
    foreach (char e in s)
    {
        if (char.IsDigit(e) == true)
        {
            numbers = numbers + e;
        }
    }
    return numbers;
}

Console.Write("Введите строку из цифр и букв: ");
string str = Console.ReadLine();
string result = GetNumbers(str);
Console.Write($"{result} ");

int CountNumbers (int num)
{
    int i = 0;
    int count = 0;
    while(i < num)
    {
        num = num / 10;
        count++;
    }
    if(i == num)
    {
        count++;
    }
    
    return count;
}

int numbers = Int32.Parse(result);
int size = CountNumbers(numbers);
//Console.Write(size);


int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = numbers % 10;
    numbers = numbers / 10; 
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

ReversArray(array);
Console.Write("Массив из цифр строки: ");
PrintArray(array);