void FillArray (int [] collection)

{
   int Length = collection.Length;
   int index = 0;
   while (index < Length)
   {
     collection [index] = new Random ().Next (1,10);
     index++;
   }
}

void PrintArray ( int [] coll)  // void - метод который ничего не возвращает.
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine (coll[position]);
        position++;
    }
}

int IndexOf (int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection [index] == find)
        {
            position = index;
            break;
        }
        index++;

    }
    return position;
}

int [] array = new int [10];

FillArray (array);
PrintArray (array);
Console.WriteLine ();

int pos = IndexOf (array, 6);
Console.WriteLine (pos);