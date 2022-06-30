// Массивы 
int Max (int arg1, int arg2,int arg3)
{
  int result = arg1;
  if (arg2 > result) result = arg2;
  if (arg3 > result) result = arg3;
  return result;
}
//      индексы 0   1  2   3   4  5   6   7   8   9
int [] array = {12,124,15,122,134,52,268,351,428,325};

int max = Max (Max(array[0],array[1],array[2]),
          Max(array[4],array[5],array[6]),
          Max(array[7],array[8],array[9]));

Console.WriteLine (max);