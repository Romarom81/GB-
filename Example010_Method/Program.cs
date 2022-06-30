int [] array = {17,72,34,45,51,69,72,87,90};
int n = array.Length;
int find = 72;
int index =0;
while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine (index);
        break;
    }
    index++;
}