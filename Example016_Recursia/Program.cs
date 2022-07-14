// Рекурсия - это использование метода внутри себя. 
// Факториал это пример рекурсии т.к 
//каждое последующее число является суммой 2х предыдущих

double Factorial(int n)
{
  if (n == 1) return 1;
  else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(5));
