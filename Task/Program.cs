//task 4

Console.Clear();
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
if (a >= b && a > c)
{Console.WriteLine("Первое число больше других");

}
else if (b >= a && b >= c)
{Console.WriteLine("Второе число больше других");  

}
else if (c >= a && c >= b)
{Console.WriteLine("Третье число больше других");  

}