char[,] charArray = new char[,]
        {
            { 'H', 'e', 'l', 'l' },
            { 'o', ' ', 'W', 'o' },
            { 'r', 'l', 'd', '!' }
        };

int rowCount = charArray.GetLength(0);
int colCount = charArray.GetLength(1);

string result = "";
for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < colCount; j++)
    {
        result += charArray[i, j];
    }
}

Console.WriteLine(result);