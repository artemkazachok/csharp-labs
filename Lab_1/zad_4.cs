static class zad4
{
    public static void Run()
    {
        Console.WriteLine("Какое значение q вы хотите: \n1:2x\n2:x^2\n3:x/3\nВведите число: ");
        Int32 n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите z:");
        Double z = Double.Parse(Console.ReadLine());
        Double x = 0;
        if (z >= 0)
        {
            x = 2 * z + 1;
            Console.WriteLine($"x={x}");
        }
        if (z < 0)
        {
            x = Math.Log(Math.Pow(z, 2) - z);
            Console.WriteLine($"x={x}");
        }
        Console.WriteLine("Введите a:");
        Double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите c:");
        Double c = Double.Parse(Console.ReadLine());
        Double y = 0;

        switch (n)
        {
            case 1:
                y = Math.Pow(Math.Sin(2 * x), 2) + a * Math.Pow(Math.Cos(Math.Pow(x, 3)), 5) + c * Math.Log(Math.Pow(x, 2.0 / 5.0));
                Console.WriteLine($"y={y}\nПри q = 2x");
                break;
            case 2:
                y = Math.Pow(Math.Sin(Math.Pow(x, 2)), 2) + a * Math.Pow(Math.Cos(Math.Pow(x, 3)), 5) + c * Math.Log(Math.Pow(x, 2.0 / 5.0));
                Console.WriteLine($"y={y}\nПри q = x^2");
                break;
            case 3:
                y = Math.Pow(Math.Sin(x / 3.0), 2) + a * Math.Pow(Math.Cos(Math.Pow(x, 3)), 5) + c * Math.Log(Math.Pow(x, 2.0 / 5.0));
                Console.WriteLine($"y={y}\nПри q = x/3");
                break;
            default:
                Console.WriteLine("Нет такого задания!");
                break;
        }
    }
}