// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите числа а и b:");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if(b*b == a)
{
   Console.Write("ДА");
}
else
{
    Console.Write("НЕТ");
}