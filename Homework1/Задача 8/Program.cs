int i = 1;

Console.Write("Введите целое натуральное число n = ");
int n = Convert.ToInt32(Console.ReadLine());

while (i <= n)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}

if (n < 2)
{
    Console.WriteLine("Нет чётных чисел!");
}
