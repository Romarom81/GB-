// Создание алгоритма сортировки методом выбора, или мин/макс
// Есть последовательность чисел 
// этапы функции - найти позицию неотсортированного элемента,
// произвести обмен рабочего (следующего неотсортированного) на тот, который выявили минимальный
// повторяем пока все не отсортируем (длина массива)
//  выводим массив
int [] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 3 };

void PrintArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine ();
}
void Sorting (int[] array)
{
   for (int i = 0; i < array.Length-1; i++)
   {
    int minPosition = i;
    for (int j = i+1; j < array.Length; j++)
    {
        if(array[j] < array [minPosition]) minPosition = j;
    }


    int temp = array [i];
    array [i] = array [minPosition];
    array [minPosition] = temp;



   }
}


PrintArray (arr);
Sorting (arr);
PrintArray (arr);
// изменить методы так, чтобы программа выстраивала массив 
//в обратном порядке (по убыванию)