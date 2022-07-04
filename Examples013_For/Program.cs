// Решение задачи с использованием цикла For
string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// индексы     012345 строки ниже
// string s = "qwerty"
// координаты буквы : s[2] - есть буква r в данной строке
string Replace (string text, char oldValue, char newValue) 
{
   string result = String.Empty;
   int length = text.Length;
   for (int i = 0; i < length; i++)
   {
     if(text [i] == oldValue) result = result + $"{newValue}";
     else result = result + $"{text [i]}";
   }
   return result;
}
string newText = Replace (text, ' ', '|'); // аргументы text - заданный ткст
                                           // ' ' пробел - это oldValue
                                           // '|' черточки - это newValue
Console.WriteLine (newText);
Console.WriteLine ();
newText = Replace (newText,'к', 'К'); 
Console.WriteLine (newText);
Console.WriteLine ();
newText = Replace (newText, 'С', 'с'); 
Console.WriteLine (newText);
Console.WriteLine ();
// Метод можно применять сколько угодно раз, мы направляем в метод полученный newText, только менять аргументы oldValue и newValue,
// показывая что на что менять.
