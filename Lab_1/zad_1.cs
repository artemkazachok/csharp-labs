static class zad1
{
    public static void Run()
    {
        Console.WriteLine("Введите x: ");
        double x = Double.Parse(Console.ReadLine());
        Console.WriteLine("Введите y: ");
        double y = Double.Parse(Console.ReadLine());
        if((x >= 1 && x <= 3 ) && (y >= -3 && y <= 1))
        {
            Console.WriteLine("Точка M принадлежит множеству D");
        }
        else
        {
        Console.WriteLine("Точка M НЕ принадлежит множеству D");
        }
    }
}