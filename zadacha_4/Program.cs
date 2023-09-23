// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int MyMax(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    return b;
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a == b && b == c && c == a)
{
    Console.WriteLine("Числа равны");
    return;
}

Console.WriteLine(MyMax(MyMax(a, b), MyMax(b, c)) + " больше");