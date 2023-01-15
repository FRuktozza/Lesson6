Console.WriteLine("Введите точки b1, k1, b2, k2");
int[] dots = new int[4];

for (int i = 0; i < 4; i++)
{
    dots[i] = Convert.ToInt32(Console.ReadLine());
}

if (dots[1] == dots[3])
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = (double) (dots[2] - dots[0]) / (dots[1] - dots[3]); // x = (b2 - b1) / (k1 - k2)
    double y = dots[1] * x + dots[0];

    Console.WriteLine($"({x}, {y})");
}
