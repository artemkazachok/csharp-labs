const Double R = 7;
Double x, y;
for(int i = 0; i < 10; i++)
{
    Console.Write("Ââåäèòå x: ");
    x = Double.Parse(Console.ReadLine());
    Console.Write("Ââåäèòå y: ");
    y = Double.Parse(Console.ReadLine());
    if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R, 2) && x >= 0) || (x >= -R && y >= x && y <= -x))
    {
        Console.WriteLine("ÏÎÏÀË!");
    }
    else
    {
        Console.WriteLine("ÌÈÌÎ!");
    }
}