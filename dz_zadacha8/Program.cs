// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
int i = 1;
while(i<num+1)
{
   if(i%2==0)
   {Console.Write(i + " ");};
i = i + 1;
   
}