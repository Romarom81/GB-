// Вид 1 метода
void Method1 ()
{
    Console.WriteLine ("Авторо - ФИО");
}
Method1 ();
// Вид 2 метода
void Method2 (string msg)
{
    Console.WriteLine (msg);
}
Method2 ("Текс вводный");

void Method2_1 (string msg, int count) // выводит сообщение count раз.
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine (msg);
        i++;
    }
}
Method2_1 (msg:"Текст",count:2);
//Method2_1 (count:4, msg: "Любой текст"); если аргументы именованные, то можно вводить не по порядку

// Вид 3 метода
int Method3 ()
{
    return DateTime.Now.Year;
}

int year = Method3 ();
//Console.WriteLine (year);

// Вид 4 метода
//string Method4 ( int count, string Text)
//{
 //   int i = 0;
//    string result = String.Empty;

//    while (i < count)
 //   {
 //       result = result + Text;
 //       i++;
  //  }
 //   return result;
//}
// string res = Method4 (2, "Как дела?");
// Console.Write (res);

// Вид 4 только через цикл - For
string Method4 ( int count, string Text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + Text;
    }
    return result;
}
string res = Method4 (6, "Как дела?");
//Console.Write (res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine ($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}