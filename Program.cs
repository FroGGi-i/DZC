//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
int a, b; 
Console.WriteLine("Введите два числа : "); 
a = Convert.ToInt32(Console.ReadLine()); 
b = Convert.ToInt32(Console.ReadLine()); 
    if (a > b) 
{Console.WriteLine("{0} наибольшее число", a);} 
    else
{Console.WriteLine("{0} наибольшее число", b);}


//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
if (a > c)
Console.WriteLine("Максимальное число: " + a);
else
Console.WriteLine("Максимальное число: " + c);
else if (b > c)
Console.WriteLine("Максимальное число: " + b);
else
Console.WriteLine("Максимальное число: " + c);


//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

Console.Clear();
int i;
Console.Write("Введите число : ");
i = Convert.ToInt32(Console.ReadLine());
if (i % 2 == 0)
Console.Write("Введенное число является четным");
else
Console.Write("Введенное число нечетное");