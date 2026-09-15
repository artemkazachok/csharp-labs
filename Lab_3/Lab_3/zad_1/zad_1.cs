Double first_x = -10;
Double last_x = 8;
Double y = 0;
Console.WriteLine(new String('_', 19));
Console.WriteLine($"| {"X",6} | {"Y",6} |");
Console.WriteLine(new String('_', 19));
for (Double i = first_x; i < last_x; i += 0.5)
{
    if(i >= -10 && i <= -6)
    {
        y = -2 - (Math.Sqrt(4 - Math.Pow((i + 8), 2)));
    }
    else if(i > -6 && i <= 2)
    {
        y = (0.5 * i) + 1;
    }
    else if (i > 2 && i <= 6)
    {
        y = 0;
    }
    else if (i > 6 && i <= 8)
    {
        y = Math.Pow((i - 6), 2);
    }
    Console.WriteLine($"| {i,6:F1} | {y,6:F2} |");
}
Console.WriteLine(new String('_', 19));