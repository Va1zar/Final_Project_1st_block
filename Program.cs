﻿string[] array = { "1t", "wasn't", "a", "very", "fast", "s0lve", "0f", "th1s", "task", "xD IMH0" };
PrintArray(array);
Console.Write(" --> ");
PrintArray(ChangedArray(array));
Console.Write(" ");

string[] ChangedArray(string[] array)
{
    int c = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            c++;
        }
    }
    string[] SecondArray = new string[c];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            SecondArray[j] = array[i];
            j++;
        }
    }
    return SecondArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

