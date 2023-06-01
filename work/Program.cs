Console.WriteLine("Введите число");
int num1 = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32( Console.ReadLine() );
if (num1 > num2)
    Console.WriteLine("max = " + num1);
else
    Console.WriteLine("max = " + num2);

Console.WriteLine("Введите 3 числа:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

    if (num2 > max)
    {
    max = num2;
    }

    if (num3 > max)
    {
    max = num3;
    }

Console.WriteLine("Максимальное число - " + max);

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
    if (num % 2 == 1)
Console.WriteLine("Число нечетное");
    else 
Console.WriteLine("Число четное");

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
    while (a <= n)
    {
    if (a % 2 == 0)
        Console.Write(a + " ");
    a++;
    }
