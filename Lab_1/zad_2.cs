static class zad2
{
    public static void Run()
    {
        Console.WriteLine("Введите x:");
        double x = Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите y:");
        double y = Double.Parse(Console.ReadLine());
        double z1 = Math.Pow(Math.Cos(x),4) + Math.Pow(Math.Sin(y), 2) + (1.0/4.0)*Math.Pow(Math.Sin(2*x),2) - 1;
        double z2 = Math.Sin(y+x) * Math.Sin(y - x);
        Console.WriteLine($"z1={z1}");
        Console.WriteLine($"z2={z2}");
    }
}
