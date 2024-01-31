bool IsPalindrome(string str)
{
    string cleanedString = "";
    foreach (char c in str)
    {
        if (Char.IsLetterOrDigit(c))
        {
            cleanedString += Char.ToLower(c);
        }
    }

    string reversedString = "";

    for (int i = cleanedString.Length - 1; i >= 0; i--)
    {
        reversedString += cleanedString[i];
    }

    if(cleanedString == reversedString)
    {
        Console.WriteLine(true);
    }
    else
    {
        Console.WriteLine(false);
    }

    return cleanedString == reversedString;
}

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

//IsPalindrome(result);
IsPalindrome("123321");