Console.WriteLine("Введите количество чисел");
int m = Convert.ToInt32(Console.ReadLine());
int counter = 0;
int num;

Console.WriteLine("Введите числа");
for (int i = 0; i < m; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        counter++;
    }
}

Console.WriteLine($"Чисел больше нуля: {counter}");
