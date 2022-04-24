int[] array = { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 };



void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100};
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOF(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}


