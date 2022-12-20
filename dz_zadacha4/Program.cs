// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите 3 числа");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int max = a;
if(a>b)
{
  max = a;  
}
else
{
    max = b;
}
if(c>max)
{max = c;}
Console.Write($"Максимальное число {max}");