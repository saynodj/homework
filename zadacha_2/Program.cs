//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int MyMax(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    return b;
}

// int a=5, b=1;
// Console.WriteLine(MyMax(a, b));

// Console.WriteLine(MyMax(1, 10));

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Числа равны");
    return;
}

Console.WriteLine(MyMax(a, b) + " больше");