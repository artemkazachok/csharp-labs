static class zad1
{
    public static void Run()
    {
        Console.WriteLine("Введите a:");
        double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите b:");
        double b = Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите c:");
        double c = Double.Parse(Console.ReadLine());
        if (a == b || b == c || c == a)
        {
            Console.WriteLine("Треугольник равнобедренный");
        }
        else
        {
            Console.WriteLine("Треугольник не равнобедренный");
        }
    }
}