Double x_start = 0;
do
{ 
    Console.Write("Введите начальное x: ");
    x_start = Double.Parse(Console.ReadLine());
    if(x_start <= 1)
    {
        Console.WriteLine("X должен быть больше 1!");
    }

} while (x_start <= 1);
Double x_end = 0;
do
{
    Console.Write("Введите конечное x: ");
    x_end = Double.Parse(Console.ReadLine());
    if (x_end < x_start)
    {
        Console.WriteLine("Конец должен быть больше начала!");
    }

} while (x_end < x_start);
Double step = 0;
do
{
    Console.Write("Введите шаг:");
    step = Double.Parse(Console.ReadLine());
    if (step < 0)
    {
        Console.WriteLine("Шаг должен быть больше 0");
    }
} while (step <= 0);
Double eps = 0;
do
{
    Console.Write("Введите точность:");
    eps = Double.Parse(Console.ReadLine());
    if(eps <= 0)
    {
        Console.WriteLine("Точность должна быть больше 0");
    }

}while (eps <= 0);
for (Double i = x_start; i < x_end; i += step)
{
    double sum = Math.PI / 2.0;
    double prom_sum = 0;
    int n = 0;
    do
    {
        prom_sum = (Math.Pow((-1), n + 1)) / ((2 * n + 1) * Math.Pow(i, 2 * n + 1));
        if (Math.Abs(prom_sum) >= eps)
        {
            sum += prom_sum;
            n++;
        }
    } while (Math.Abs(prom_sum) >= eps);
    Console.WriteLine($"X:{i} arctg(x):{sum} Кол-во слагаемых: {n}");
}