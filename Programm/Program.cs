string[] FirstArray = new string[5] {"123", "23", "hello", "world", "res"};
string[] SecondArray = new string[FirstArray.Length];


void SecondArrayFunc(string[] FirstArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
    if(FirstArray[i].Length <= 3)
        {
        SecondArray[count] = FirstArray[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


SecondArrayFunc(FirstArray, SecondArray);
PrintArray(SecondArray);