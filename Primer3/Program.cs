// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
int n = -1 * number;
while(n < number)
{
Console.Write(n + " ");
n=n+1;
}