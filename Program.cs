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