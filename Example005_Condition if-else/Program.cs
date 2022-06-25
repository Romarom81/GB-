Console.Write ("Введите имя пользователя:");
string username = Console.ReadLine ();
if (username.ToLower () == "маша")
{
    Console.Write ("Уррра, это же Маша!");
}
else
{
    Console.WriteLine ("Привет, ");
    Console.WriteLine (username);
}